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
using Krypton.Toolkit;
using System.Diagnostics;

namespace GenaratorAiG
{
    public partial class Form1 : KryptonForm
    {
        private PdfBuilder pdf = new PdfBuilder();
        string fileName;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ////Можете сразу посмотреть, как будет выглядеть ваше задание в pdf файле, он в дебаге - document.pdf
                //Task_119 task = new Task_119(); //просто поменяйте таск на свой
                //pdf.HandleTask(task.GetDescription(), task.GetCondition());
                //pdf.ShowAnswer(task.GetAnswer());
                ////pdf.GeneratePdf();

                WebBrowser.DocumentText = pdf.GetHTML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            kryptonTreeView1.Nodes[0].Nodes[1].Tag = new Task_19();
            kryptonTreeView1.Nodes[0].Nodes[1].Tag = new Task_19();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            List<string> themes = new List<string>();
            foreach (TreeNode tr in kryptonTreeView1.Nodes[0].Nodes)
            {
                if (tr.Checked) 
                {
                    ITask task = tr.Tag as ITask;
                    pdf.HandleTask(task.GetDescription(), task.GetCondition());
                }
            }



            try
            {
               

                WebBrowser.DocumentText = pdf.GetHTML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Byte[] PdfSharpConvert(String html)
        {
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
                pdf.Save(ms);
                res = ms.ToArray();
            }
            return res;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            //Byte[] res = PdfSharpConvert(pdf.GetHTML());
            //using (var stream = new FileStream("file.pdf", FileMode.Create))
            //{
            //    stream.Write(res, 0, res.Length);
            //}
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDF(*.pdf)|*.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
            }
            else
            {
                return;
            }

            pdf.GeneratePdf(fileName);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            using (PrintDialog Dialog = new PrintDialog())
            {
                Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = fileName,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }
            }
        }

        private void VariousTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
