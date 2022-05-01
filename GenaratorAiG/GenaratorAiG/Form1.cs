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
        private string latex = @"x = \frac{-b\pm\sqrt{b^2-4ac}}{2a}";
        private LatexHandler latexHandler = new LatexHandler();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void GenerateImage(object sender, System.EventArgs e)
        {
            latex = richTextBox1.Text;
            pictureBox1.Image = latexHandler.CreateLatexImage(latex);
        }
    }
}
