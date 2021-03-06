﻿Imports System.Drawing.Imaging
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class ManagePDF417Barcode
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.Pdf417

            ' set Pdf417 Error correction level
            barCodeBuilder.Pdf417ErrorLevel = Pdf417ErrorLevel.Level8

            ' Set Pdf417 Compaction Mode to Text
            barCodeBuilder.Pdf417CompactionMode = Pdf417CompactionMode.Text

            ' set CodeText for barcode
            barCodeBuilder.CodeText = "1234567890"

            barCodeBuilder.Save(dataDir & Convert.ToString("ManagePDF417Barcode_out.bmp"), ImageFormat.Bmp)

            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "Datamatrixbarcode_out.bmp")
        End Sub
    End Class
End Namespace
