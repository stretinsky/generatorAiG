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
using GenaratorAiG.Tasks.SLAE;

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
            //try
            //{
                task_87 task1 = new task_87();
                string latex = task1.GetCondition() + "\\\\" + task1.GetAnswer(); // здесь ваша латех формула  

                pictureBox1.Image = latexHandler.CreateLatexImage(latex);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
