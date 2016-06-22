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
    class MarkingBarCodeRegionsInImage
    {
        public static void Run()
        {
            //ExStart:MarkingBarCodeRegionsInImage               

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

            // Create an instance of BarCodeReader and set image and symbology type to recognize
            BarCodeReader barCodeReader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code39Standard);

            int counter = 0;
            // Read all the barcodes from the images
            while (barCodeReader.Read())
            {
                // Display the symbology type
                Console.WriteLine("BarCode Type: " + barCodeReader.GetCodeType());
                // Display the codetext
                Console.WriteLine("BarCode CodeText: " + barCodeReader.GetCodeText());
                // Get the barcode region

                BarCodeRegion region = barCodeReader.GetRegion();
                if (region != null)
                {
                    // Initialize an object of type Image to get the Graphics object
                    Image image = Image.FromFile(dataDir + "code39.png");

                    // Initialize graphics object from the image
                    Graphics graphics = Graphics.FromImage(image);
                    
                    // Draw the barcode edges
                    region.DrawBarCodeEdges(graphics, new Pen(Color.Red, 1f));
                    
                    // Save the image
                    image.Save(dataDir + string.Format(@"edge_{0}.png", counter++));
                    
                    // Fill the barcode area with some color
                    region.FillBarCodeRegion(graphics, Brushes.Green);
                    image.Save(dataDir + string.Format(@"fill_{0}.png", counter++));
                }
            }
            barCodeReader.Close();
            //ExEnd:MarkingBarCodeRegionsInImage 
        }
    }
}
