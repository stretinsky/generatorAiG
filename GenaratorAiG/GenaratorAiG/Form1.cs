using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latex;
using PdfSharp;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using GenaratorAiG.Tasks.SLAE;
using GenaratorAiG.Tasks.Complex;
using GenaratorAiG.Tasks.Analytic_geometry;
using System.Threading;

namespace GenaratorAiG
{
    public partial class Form1 : Form
    {
        private PdfBuilder pdf = new PdfBuilder();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Можете сразу посмотреть, как будет выглядеть ваше задание в pdf файле, он в дебаге - document.pdf
                Task_152 task = new Task_152(); //просто поменяйте таск на свой
                pdf.HandleTask(task.GetDescription(), task.GetCondition().ToArray());
                pdf.ShowAnswer(task.GetAnswer());
                pdf.GeneratePdf();

                string latex = task.GetCondition() + "\\\\" + task.GetAnswer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
