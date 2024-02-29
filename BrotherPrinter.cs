using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

namespace BuildQtyTracker
{
    internal class BrotherPrinter
    {
        private Laptop laptop = null;
        private string SN;
        public BrotherPrinter(Laptop laptop, string SN)
        {

            this.laptop = laptop;
            this.SN = SN;

        }
        public void PrintLabel()
        {
            PrintDocument printDocument = new PrintDocument();

            // Set the printer name. Make sure this matches your printer name in Windows.
            printDocument.PrinterSettings.PrinterName = "Brother QL-570";
            // Adjust the label size here. The size is specified in hundredths of an inch.
            // For a 62mm x 100mm label, the dimensions in hundredths of an inch would be approximately (244, 394).
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom Size", 244, 394);

            // Optionally, you can set the margins if needed
            printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            // Handle the PrintPage event where you'll define what to print.
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

            // Trigger the printing process.
            printDocument.Print();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Here you can define what to print on your label.
            // For demonstration, we'll just print a simple text string.

            // Define the font and brush for the text.
            Font font = new Font("Arial", 16);
            Font bold=new Font("Arial",16, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Define the starting point
            PointF point = new PointF(10, 5);
            int gap = 23;

            // Increment the Y-coordinate by 25 pixels for each subsequent point
            PointF point2 = new PointF(10, point.Y + gap);
            PointF point3 = new PointF(10, point2.Y + gap);
            PointF point4 = new PointF(10, point3.Y + gap);
            PointF point5 = new PointF(10, point4.Y + gap);
            PointF point6 = new PointF(10, point5.Y + gap);
            PointF point7 = new PointF(10, point6.Y + gap);
            PointF point8 = new PointF(10, point7.Y + gap);
            PointF point9 = new PointF(10, point8.Y + gap);
            PointF point10 = new PointF(10, point9.Y + gap);

            // Draw the string on the label.
            e.Graphics.DrawString($"Model:{laptop.model}", bold, brush, point);
            e.Graphics.DrawString($"CPU:{laptop.cpu}", font, brush, point2);
            e.Graphics.DrawString($"Memory:{laptop.memory}", font, brush, point3);
            e.Graphics.DrawString($"HDD/SSD:{laptop.storage}", font, brush, point4);
            e.Graphics.DrawString($"Screen:{laptop.screen}", font, brush, point5);
            e.Graphics.DrawString($"Colour:{laptop.colour}", font, brush, point6);
            e.Graphics.DrawString($"Grade:{laptop.grade}", font, brush, point7);
            e.Graphics.DrawString($"S/N:{SN}", font, brush, point8);
            e.Graphics.DrawString($"SKU:{laptop.SKU}", font, brush, point9);
            e.Graphics.DrawString($"Windows:{laptop.windows}", font, brush, point10);
        }
    }
}
