namespace ImageConverterApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        internal System.Windows.Forms.ListBox lstImagenes;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.TextBox txtAncho;
        internal System.Windows.Forms.TextBox txtAlto;
        internal System.Windows.Forms.Label lblAncho;
        internal System.Windows.Forms.Label lblAlto;
        internal System.Windows.Forms.CheckBox chkMantenerAspectRatio;
        internal System.Windows.Forms.ComboBox cmbFormato;
        internal System.Windows.Forms.Button btnConvertir;
        internal System.Windows.Forms.Label lblUnidad;
        internal System.Windows.Forms.ComboBox cmbUnidad; // Para seleccionar "px", "cm" o "mm"

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No modifique el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstImagenes = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.chkMantenerAspectRatio = new System.Windows.Forms.CheckBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstImagenes
            // 
            this.lstImagenes.AllowDrop = true;
            this.lstImagenes.FormattingEnabled = true;
            this.lstImagenes.ItemHeight = 15;
            this.lstImagenes.Location = new System.Drawing.Point(20, 20);
            this.lstImagenes.Name = "lstImagenes";
            this.lstImagenes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstImagenes.Size = new System.Drawing.Size(300, 200);
            this.lstImagenes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(340, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Add Image / Agregar Imagen";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(340, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(240, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Remove Image / Eliminar Imagen";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(130, 237);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 23);
            this.txtAncho.TabIndex = 3;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(130, 277);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(100, 23);
            this.txtAlto.TabIndex = 4;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(20, 240);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(89, 15);
            this.lblAncho.TabIndex = 5;
            this.lblAncho.Text = "Width / Ancho:";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(20, 280);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(88, 15);
            this.lblAlto.TabIndex = 6;
            this.lblAlto.Text = "Height / Alto:";
            // 
            // chkMantenerAspectRatio
            // 
            this.chkMantenerAspectRatio.AutoSize = true;
            this.chkMantenerAspectRatio.Location = new System.Drawing.Point(20, 320);
            this.chkMantenerAspectRatio.Name = "chkMantenerAspectRatio";
            this.chkMantenerAspectRatio.Size = new System.Drawing.Size(245, 19);
            this.chkMantenerAspectRatio.TabIndex = 7;
            this.chkMantenerAspectRatio.Text = "Maintain Aspect Ratio / Mantener Aspect Ratio";
            this.chkMantenerAspectRatio.UseVisualStyleBackColor = true;
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "WEBP",
            "GIF",
            "BMP",
            "TIFF",
            "ICO",
            "PDF"});
            this.cmbFormato.Location = new System.Drawing.Point(20, 360);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(150, 23);
            this.cmbFormato.TabIndex = 8;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(20, 400);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(171, 15);
            this.lblUnidad.TabIndex = 10;
            this.lblUnidad.Text = "Measurement Unit / Unidad:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "px",
            "cm",
            "mm"});
            this.cmbUnidad.Location = new System.Drawing.Point(200, 397);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(120, 23);
            this.cmbUnidad.TabIndex = 11;
            this.cmbUnidad.SelectedIndex = 0;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(340, 360);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(240, 30);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convert Images / Convertir Imágenes";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.cmbUnidad);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.chkMantenerAspectRatio);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstImagenes);
            this.Name = "Form1";
            this.Text = "Image Converter App / Convertidor de Imágenes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
