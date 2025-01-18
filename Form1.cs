using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ImageMagick;

namespace ImageConverterApp
{
    public partial class Form1 : Form
    {
        // La lista de imágenes ya se declara aquí para que sea accesible en toda la clase
        private List<string> listaImagenes = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Asociar eventos de Drag & Drop en caso de no haberlo hecho en el Designer
            lstImagenes.DragEnter += LstImagenes_DragEnter;
            lstImagenes.DragDrop += LstImagenes_DragDrop;
        }

        #region Drag & Drop

        private void LstImagenes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void LstImagenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                if (IsValidImage(file) && !listaImagenes.Contains(file))
                {
                    listaImagenes.Add(file);
                    lstImagenes.Items.Add(Path.GetFileName(file));
                }
            }
        }

        #endregion

        // Valida si el archivo tiene una extensión válida para imágenes
        private bool IsValidImage(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" ||
                   ext == ".webp" || ext == ".gif" || ext == ".bmp" ||
                   ext == ".tif" || ext == ".tiff" || ext == ".ico" || ext == ".pdf";
        }

        // Botón: Agregar Imagen
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Filter = "Images|*.jpg;*.jpeg;*.png;*.webp;*.gif;*.bmp;*.tif;*.tiff;*.ico;*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in dlg.FileNames)
                    {
                        if (IsValidImage(file) && !listaImagenes.Contains(file))
                        {
                            listaImagenes.Add(file);
                            lstImagenes.Items.Add(Path.GetFileName(file));
                        }
                    }
                }
            }
        }

        // Botón: Eliminar Imagen (ahora permite eliminar varios elementos seleccionados)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItems.Count > 0)
            {
                // Crear una lista temporal de los elementos seleccionados
                var itemsToRemove = new List<string>();
                foreach (var item in lstImagenes.SelectedItems)
                {
                    itemsToRemove.Add(item.ToString());
                }
                // Para cada elemento seleccionado, quitarlo de la lista y del ListBox
                foreach (var item in itemsToRemove)
                {
                    // Obtener la ruta original correspondiente
                    int index = lstImagenes.Items.IndexOf(item);
                    if (index >= 0)
                    {
                        lstImagenes.Items.RemoveAt(index);
                        listaImagenes.RemoveAt(index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one or more images to remove / Selecciona una o más imágenes para eliminar",
                                "Warning / Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón: Convertir Imágenes
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Count == 0)
            {
                MessageBox.Show("Please add at least one image / Agrega al menos una imagen.",
                                "Warning / Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                if (folderDlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in listaImagenes)
                    {
                        try
                        {
                            ResizeAndConvertImage(path, folderDlg.SelectedPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing " + Path.GetFileName(path) + ": " + ex.Message);
                        }
                    }
                    MessageBox.Show("Conversion completed / Conversión completada.",
                                    "Success / Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Redimensiona y convierte la imagen desde la ruta de origen a la carpeta de destino,
        /// utilizando los valores de ancho/alto y el formato especificado por el usuario.
        /// Se utiliza Magick.NET para soportar múltiples formatos.
        /// </summary>
        private void ResizeAndConvertImage(string sourcePath, string destFolder)
        {
            using (var image = new MagickImage(sourcePath))
            {
                // Convertir propiedades de tipo uint a int
                int originalWidth = (int)image.Width;
                int originalHeight = (int)image.Height;
                int newWidth = 0, newHeight = 0;

                // Leer los valores ingresados para ancho y alto
                int.TryParse(txtAncho.Text, out newWidth);
                int.TryParse(txtAlto.Text, out newHeight);

                // Obtener la unidad de medida (px, cm o mm) seleccionada
                string unidad = cmbUnidad.SelectedItem.ToString().ToLower();
                // Factor de conversión de la unidad ingresada a píxeles (usando 96 DPI)
                double factor = 1.0;
                if (unidad == "cm")
                    factor = 96.0 / 2.54; // Aproximadamente 37.7953
                else if (unidad == "mm")
                    factor = 96.0 / 25.4; // Aproximadamente 3.77953

                // Convertir las medidas ingresadas a píxeles (si se han ingresado)
                if (newWidth > 0) newWidth = (int)(newWidth * factor);
                if (newHeight > 0) newHeight = (int)(newHeight * factor);

                // Si "Mantener Aspect Ratio" está activado, calcular la dimensión faltante
                if (chkMantenerAspectRatio.Checked)
                {
                    if (newWidth > 0 && newHeight == 0)
                    {
                        newHeight = (int)((double)newWidth * originalHeight / originalWidth);
                    }
                    else if (newHeight > 0 && newWidth == 0)
                    {
                        newWidth = (int)((double)newHeight * originalWidth / originalHeight);
                    }
                    else if (newWidth == 0 && newHeight == 0)
                    {
                        newWidth = originalWidth;
                        newHeight = originalHeight;
                    }
                }
                else
                {
                    if (newWidth == 0)
                        newWidth = originalWidth;
                    if (newHeight == 0)
                        newHeight = originalHeight;
                }

                // Redimensionar la imagen (se requiere uint)
                image.Resize((uint)newWidth, (uint)newHeight);

                // Determinar el formato de salida y la extensión correspondiente
                string selectedFormat = cmbFormato.SelectedItem.ToString().ToUpper();
                MagickFormat outputFormat;
                string ext;
                switch (selectedFormat)
                {
                    case "JPG":
                    case "JPEG":
                        outputFormat = MagickFormat.Jpeg;
                        ext = ".jpg";
                        break;
                    case "PNG":
                        outputFormat = MagickFormat.Png;
                        ext = ".png";
                        break;
                    case "WEBP":
                        outputFormat = MagickFormat.WebP;
                        ext = ".webp";
                        break;
                    case "GIF":
                        outputFormat = MagickFormat.Gif;
                        ext = ".gif";
                        break;
                    case "BMP":
                        outputFormat = MagickFormat.Bmp;
                        ext = ".bmp";
                        break;
                    case "TIFF":
                        outputFormat = MagickFormat.Tiff;
                        ext = ".tiff";
                        break;
                    case "ICO":
                        outputFormat = MagickFormat.Ico;
                        ext = ".ico";
                        break;
                    case "PDF":
                        outputFormat = MagickFormat.Pdf;
                        ext = ".pdf";
                        break;
                    default:
                        outputFormat = MagickFormat.Png;
                        ext = ".png";
                        break;
                }
                image.Format = outputFormat;
                string outputFileName = System.IO.Path.GetFileNameWithoutExtension(sourcePath) + "_conv" + ext;
                string destPath = System.IO.Path.Combine(destFolder, outputFileName);
                image.Write(destPath);
            }
        }
    }
}
