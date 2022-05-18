using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latex;

namespace GenaratorAiG
{
    public partial class Form1 : Form
    {
        private LatexImageBuilder latexHandler = new LatexImageBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string latex = @"\frac{2}{3}"; // здесь ваша латех формула  

                pictureBox1.Image = latexHandler.CreateLatexImage(latex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
