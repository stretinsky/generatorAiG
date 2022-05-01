using System.Windows.Forms;
using System.IO;
using WpfControlLibrary1;
using System.Drawing;
using System;

namespace GenaratorAiG
{
    public partial class Form1 : Form
    {
        private Image im = new Bitmap(1, 1);
        private string latex = @"\frac{2+2}{2}";
        private LatexHandler latexHandler = new LatexHandler();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void GenerateImage(object sender, System.EventArgs e)
        {
            latex = richTextBox1.Text;
            im.Dispose();
            string fileName = latexHandler.CreateLatexImage(latex);
            im = new Bitmap(fileName);
            pictureBox1.Image = im;
        }
    }
}
