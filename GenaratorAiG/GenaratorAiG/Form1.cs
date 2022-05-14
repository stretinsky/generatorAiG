using System.Windows.Forms;
using System.IO;
using WpfControlLibrary1;
using System.Drawing;
using System;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Numerics;
using Tasks;
using PdfSharp.Pdf;
using PdfSharp;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace GenaratorAiG
{
    public partial class Form1 : Form
    {
        private string latex = @"x = \frac{-b\pm\sqrt{b^2-4ac}}{2a}";
        string html;
        Random r;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private LatexHandler latexHandler = new LatexHandler();
        private void GenerateImage(object sender, EventArgs e)
        {
            try
            {
                Task1_1_4 task1 = new Task1_1_4();
                latex = task1.GetTaskLatex()[0] + "\\\\" + task1.GetTaskLatex()[1]; // + "\\\\" + task1.AnswerLatex;
                //latex = richTextBox1.Text;
                pictureBox1.Image = latexHandler.CreateLatexImage(latex);

                int name = r.Next(100000, 999999);
                pictureBox1.Image.Save($@"temp\{name}.jpeg");
                
                // TODO пропорционально регулировать изображение картинки, чтобы оно не вылазило за пределы pdf
                html += $"<p>{task1.Description}</p>";
                html += $"<p><img src = \"{Directory.GetCurrentDirectory() + $@"\temp\{name}.jpeg"}\";quality=96&amp;type=album\" alt = \"\" width=\"{pictureBox1.Image.Width}\" height=\"{pictureBox1.Image.Height}\"/>&nbsp;</p>";
                PdfDocument pdf = PdfGenerator.GeneratePdf(html, PageSize.A4);
                pdf.Save("document.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
            int dwRop // raster operation code
        );

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

        private Stream streamToPrint;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = Image.FromStream(streamToPrint);

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
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }

        public void StartPrint(Stream streamToPrint, string streamType)
        {

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.streamToPrint = streamToPrint;

            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

    }
}
