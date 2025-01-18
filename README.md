
# ImageConverterApp / Image Converter

A Windows Forms application in C# (.NET Framework 4.8) that allows you to **add, resize, and convert images** between multiple formats using the [Magick.NET-Q16-HDRI-AnyCPU](https://www.nuget.org/packages/Magick.NET-Q16-HDRI-AnyCPU) library.  
This application supports conversion between JPG, PNG, WEBP, GIF, BMP, TIFF, ICO, and PDF. Additionally, you can select the unit of measurement (px, cm, or mm) for specifying dimensions, and use the "Maintain Aspect Ratio" option which automatically calculates the missing value.

---

## Table of Contents

- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Customization](#customization)
- [License](#license)
- [Acknowledgments](#acknowledgments)

---

## Features

- **Add Images:**  
  Select or drag images (JPG, PNG, WEBP, GIF, BMP, TIFF, ICO, PDF) into a list.
- **Remove Images:**  
  Remove one or multiple selected images from the list.
- **Resize:**  
  Specify new width and/or height values. You can choose the measurement unit (px, cm, or mm). If "Maintain Aspect Ratio" is enabled, entering one dimension automatically calculates the other.
- **Format Conversion:**  
  Convert the image to a chosen output format (JPG, PNG, WEBP, GIF, BMP, TIFF, ICO, PDF) with proper compression using Magick.NET.

---

## Requirements

- Windows 10 or higher.
- .NET Framework 4.8.
- Visual Studio 2022 (or a compatible version).
- [Magick.NET-Q16-HDRI-AnyCPU](https://www.nuget.org/packages/Magick.NET-Q16-HDRI-AnyCPU) installed via NuGet.

---

## Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/your_username/ImageConverterApp.git
   ```

2. **Open the project in Visual Studio:**

   Open the solution file (`.sln`) in Visual Studio 2022.

3. **Install Dependencies:**

   Use the NuGet Package Manager to install **Magick.NET-Q16-HDRI-AnyCPU**.

---

## Usage

1. **Build and Run:**

   Compile the solution and run the application from Visual Studio or by executing the generated `.exe` in `bin\Debug` or `bin\Release`.

2. **Add Images:**

   Click "Add Image" or drag and drop images (supported formats: JPG, PNG, WEBP, GIF, BMP, TIFF, ICO, PDF) into the list.

3. **Remove Images:**

   Select one or more images (using Ctrl or Shift to select multiple) and click "Remove Image" to delete them from the list.

4. **Set Dimensions and Unit:**

   Enter the desired width and/or height in the provided text boxes. Then, select the measurement unit (px, cm, or mm) from the corresponding ComboBox.  
   If "Maintain Aspect Ratio" is checked, entering one dimension will automatically calculate the other.

5. **Choose Output Format:**

   Select the desired output format from the ComboBox (options: JPG, PNG, WEBP, GIF, BMP, TIFF, ICO, PDF).

6. **Convert Images:**

   Click "Convert Images", choose a destination folder, and the application will process the images accordingly, saving them with the new dimensions and selected format.

---

## Project Structure

```
ImageConverterApp/
│
├── ImageConverterApp.sln         # Visual Studio solution file.
├── ImageConverterApp/             # Main project folder.
│   ├── Program.cs                # Entry point of the application.
│   ├── Form1.cs                  # Contains the application logic.
│   ├── Form1.Designer.cs         # Contains control declarations and design code.
│   └── (other resource/configuration files)
└── README.md                     # This file.
```

---

## Customization

- **User Interface:**  
  You can adjust the layout and add more controls (e.g., image preview functionality) as needed.
- **Extended Format Support:**  
  The application supports multiple image formats. For further formats or advanced options, consult the [Magick.NET Documentation](https://github.com/dlemstra/Magick.NET).
- **Error Handling:**  
  Enhance validation and error handling according to your project requirements.

---

## License

This project is distributed under the **MIT License**.

---

## Acknowledgments

- [Magick.NET-Q16-HDRI-AnyCPU](https://www.nuget.org/packages/Magick.NET-Q16-HDRI-AnyCPU) – For real image processing and native support for various formats.
- [Microsoft .NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) – Development platform.
- **José Luis Iñigo a.k.a. Riskoo** – Author and maintainer.
```
