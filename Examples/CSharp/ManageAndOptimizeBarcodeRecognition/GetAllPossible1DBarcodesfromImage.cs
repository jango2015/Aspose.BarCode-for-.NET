﻿using System.IO;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class GetAllPossible1DBarcodesfromImage
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                // Initialize the BarCodeReader object
                BarCodeReader reader = new BarCodeReader(dataDir + "Barcode2.png", DecodeType.AllSupportedTypes);
                // Call read memthod
                reader.Read();

                // Now get all possible barcodes
                BarCodeReader.PossibleBarCode[] barcodes = reader.GetAllPossibleBarCodes();

                foreach (BarCodeReader.PossibleBarCode barcode in barcodes)
                {
                    // Display code text, symbology, detected angle, recognition percentage of the barcode
                    Console.WriteLine("Code Text: " + barcode.Codetext + " Symbology: " + barcode.BarCodeReadType + " Recognition percentage: " + barcode.Angle);

                    // Display x and y coordinates of barcode detected
                    System.Drawing.Point[] point = barcode.Region.Points;
                    Console.WriteLine("Top left coordinates: X = " + point[0].X + ", Y = " + point[0].Y);
                    Console.WriteLine("Bottom left coordinates: X = " + point[1].X + ", Y = " + point[1].Y);
                    Console.WriteLine("Bottom right coordinates: X = " + point[2].X + ", Y = " + point[2].Y);
                    Console.WriteLine("Top right coordinates: X = " + point[3].X + ", Y = " + point[3].Y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}

