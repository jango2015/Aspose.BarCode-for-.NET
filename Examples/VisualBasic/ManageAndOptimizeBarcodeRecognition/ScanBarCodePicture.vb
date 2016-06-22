﻿Imports System.IO
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ScanBarCodePicture
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            Try
                'ExStart:ScanBarCodePicture
                ' Read file from directory with DecodeType.EAN13
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("Scan.jpg"), DecodeType.EAN13)
                While reader.Read()
                    ' Read symbology type
                    Console.WriteLine("Symbology Type: " & reader.GetCodeType().ToString())
                    ' Read code text
                    Console.WriteLine("CodeText: " & reader.GetCodeText().ToString())
                End While
                'ExEnd:ScanBarCodePicture 
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace