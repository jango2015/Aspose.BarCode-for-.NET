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
    class ManualHints
    {
        public static void Run()
        {
            try
            {
                Stopwatch watch = new Stopwatch();

                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                using (BarCodeReader reader = new BarCodeReader(dataDir + "SymbologyTypebarcode.png", DecodeType.Code128))
                {
                    // Start Stopwatch
                    watch.Start();

                    // Set RecognitionMode
                    reader.RecognitionMode = RecognitionMode.ManualHints;

                    // Set ManualHints
                    reader.ManualHints = ManualHint.MedianSmoothing;

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());
                    }
                    // End Stopwatch
                    watch.Stop();
                    Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}