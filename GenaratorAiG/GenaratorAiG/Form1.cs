﻿using System;
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
using System.Threading;

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
                Task_72 task = new Task_72();
           
                string latex = task.GetCondition() + "\\\\" + task.GetAnswer(); // здесь ваша латех формула  

                pictureBox1.Image = latexHandler.CreateLatexImage(latex);


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

    }
}
