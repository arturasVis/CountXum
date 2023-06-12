using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using BarcodeLib;

public class ZebraLabelPrinter
{
    private string _printerName;
    private string _barcodeData;
    private string _labelText;

    public ZebraLabelPrinter(string printerName)
    {
        _printerName = printerName;
    }

    public void PrintLabelWithText(string barcodeData, string labelText)
    {
        _barcodeData = barcodeData;
        _labelText = labelText;

        // Set up the PrintDocument and the PrintPage event handler
        using (var printDocument = new PrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = _printerName;
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", InchesToHundredths(4), InchesToHundredths(6));
            printDocument.PrintPage += PrintDocument_PrintPageWithText;
            printDocument.Print();
        }
    }

    private void PrintDocument_PrintPageWithText(object sender, PrintPageEventArgs e)
    {
        // Create a barcode image using BarcodeLib
        var barcode = new Barcode();
        barcode.IncludeLabel = true;
        var barcodeImage = barcode.Encode(TYPE.CODE128, _barcodeData, Color.Black, Color.White, 100, 40);

        // Draw the barcode image on the PrintDocument
        e.Graphics.DrawImage(barcodeImage, 0, 540);

        // Draw the text below the barcode image
        using (var font = new Font("Arial", 12, FontStyle.Regular))
        {
            e.Graphics.DrawString(_labelText, font, Brushes.Black, 0, 20);
        }
    }

    private int InchesToHundredths(float inches)
    {
        return (int)(inches * 100);
    }
}

