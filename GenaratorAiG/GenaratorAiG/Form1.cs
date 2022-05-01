using System.Windows.Forms;
using System.IO;
using WpfControlLibrary1;
using System.Drawing;
using System;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace GenaratorAiG
{
    public partial class Form1 : Form
    {
        //начало копирования
        private Stream streamToPrint;

        string streamType;

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);

            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;

            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }


        private void DoSomething(object sender, EventArgs e)
        {
            string filename = "screen.png";

            Graphics g1 = CreateGraphics();
            Image MyImage = new Bitmap(ClientRectangle.Width, ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(filename, ImageFormat.Png);
            MessageBox.Show(filename);
            //FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            //StartPrint(fileStream, "Image");
            //fileStream.Close();
            //if (System.IO.File.Exists(filename))
            //{
            //    System.IO.File.Delete(filename);
            //}
        }

        public void StartPrint(Stream streamToPrint, string streamType)
        {

            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            this.streamToPrint = streamToPrint;

            this.streamType = streamType;

            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();

            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        //конец копирования
        private Image im = new Bitmap(1, 1);
        private string latex = @"x = \frac{-b\pm\sqrt{b^2-4ac}}{2a}";
        private LatexHandler latexHandler = new LatexHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateImage(object sender, System.EventArgs e)
        {
            try
            {
                latex = richTextBox1.Text;
                im.Dispose();
                pictureBox1.Image = latexHandler.CreateLatexImage(latex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
