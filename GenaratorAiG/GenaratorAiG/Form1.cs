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
using System.Drawing.Printing;
using GenaratorAiG.Tasks.SLAE;
using GenaratorAiG.Tasks.Complex;
using GenaratorAiG.Tasks.Analytic_geometry;
using GenaratorAiG.Tasks.Determinants;
using System.Threading;
using Krypton.Toolkit;
using System.Diagnostics;

namespace GenaratorAiG
{
    public partial class Form1 : KryptonForm
    {
        private PdfBuilder pdf = new PdfBuilder();
        private PdfBuilder pdfAnswers = new PdfBuilder();
        string fileName;
        byte counter = 0, variant;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 500);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            pdf.ClearHtml();
            pdf.Various = 0;
            variant = Convert.ToByte(VariantTextBox.Text);
            pdfAnswers.ClearHtml();
            pdfAnswers.Various = 0;
            Random random = new Random();

            for (int k = 0; k < variant; k++)
            {
                ////Complex
                kryptonTreeView1.Nodes[0].Nodes[1].Tag = new Task_19(random);
                kryptonTreeView1.Nodes[0].Nodes[0].Tag = new Task_4(random);


                //Determinants
                kryptonTreeView1.Nodes[1].Nodes[0].Tag = new Task1_2_46(random);
                kryptonTreeView1.Nodes[1].Nodes[1].Tag = new Task1_2_58(random);
                kryptonTreeView1.Nodes[1].Nodes[2].Tag = new Task1_2_60(random);
                kryptonTreeView1.Nodes[1].Nodes[3].Tag = new Task1_2_67(random);
                kryptonTreeView1.Nodes[1].Nodes[4].Tag = new Task1_2_68(random);
                kryptonTreeView1.Nodes[1].Nodes[5].Tag = new Task1_2_69(random);
                kryptonTreeView1.Nodes[1].Nodes[6].Tag = new Task1_2_70(random);


                //SLAE
                kryptonTreeView1.Nodes[2].Nodes[0].Tag = new Task_72(random);
                kryptonTreeView1.Nodes[2].Nodes[1].Tag = new Task_73(random);
                kryptonTreeView1.Nodes[2].Nodes[2].Tag = new Task_74(random);
                kryptonTreeView1.Nodes[2].Nodes[3].Tag = new Task_76(random);
                kryptonTreeView1.Nodes[2].Nodes[4].Tag = new Task_80(random);
                kryptonTreeView1.Nodes[2].Nodes[5].Tag = new Task_82(random);
                kryptonTreeView1.Nodes[2].Nodes[6].Tag = new Task_87(random);
                kryptonTreeView1.Nodes[2].Nodes[7].Tag = new Task_88(random);
                kryptonTreeView1.Nodes[2].Nodes[8].Tag = new Task_89(random);


                //Analytical Geometry
                kryptonTreeView1.Nodes[3].Nodes[0].Tag = new Task_104(random);
                kryptonTreeView1.Nodes[3].Nodes[1].Tag = new Task_105(random);
                kryptonTreeView1.Nodes[3].Nodes[2].Tag = new Task_108(random);
                kryptonTreeView1.Nodes[3].Nodes[3].Tag = new Task_117(random);
                kryptonTreeView1.Nodes[3].Nodes[4].Tag = new Task_118(random);
                kryptonTreeView1.Nodes[3].Nodes[5].Tag = new Task_119(random);
                kryptonTreeView1.Nodes[3].Nodes[6].Tag = new Task_125(random);
                kryptonTreeView1.Nodes[3].Nodes[7].Tag = new Task_126(random);
                kryptonTreeView1.Nodes[3].Nodes[8].Tag = new Task_152(random);
                kryptonTreeView1.Nodes[3].Nodes[9].Tag = new Task_160(random);

                pdf.Number = 0;
                pdf.Various++;
                pdf.WriteVariant();

                pdfAnswers.Number = 0;
                pdfAnswers.Various++;
                pdfAnswers.WriteVariant();

                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        foreach (TreeNode tr in kryptonTreeView1.Nodes[i].Nodes)
                        {
                            if (tr.Checked)
                            {
                                ITask task = tr.Tag as ITask;

                                pdf.HandleTask(task.GetDescription(), task.GetCondition());
                                pdf.ShowAnswer(task.GetAnswer(), false);
                                pdfAnswers.ShowAnswer(task.GetAnswer());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }

            WebBrowser.DocumentText = pdf.GetHTML();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
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

            string[] answers = fileName.Split('.');

            string file = "";
            for (int i = 0; i < answers.Length; i++)
            {
                if (i == answers.Length - 1)
                    file += "_answer.";

                file += answers[i];
            }

            pdfAnswers.GeneratePdf(file);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (WebBrowser.Url == null)
            {
                MessageBox.Show("Сначала сгенерируйте задания", "Ошибка");
            }
            else
            {
                WebBrowser.Print();
            }
        }

        private void kryptonTreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //Complex
            if (e.Action != TreeViewAction.Unknown && e.Node.Checked && e.Node == kryptonTreeView1.Nodes[0])
            {
                kryptonTreeView1.Nodes[0].Nodes[0].Checked = true;
                kryptonTreeView1.Nodes[0].Nodes[1].Checked = true;
            }
            else if (e.Action != TreeViewAction.Unknown && !e.Node.Checked && e.Node == kryptonTreeView1.Nodes[0])
            {
                kryptonTreeView1.Nodes[0].Nodes[0].Checked = false;
                kryptonTreeView1.Nodes[0].Nodes[1].Checked = false;
            }

            //Determinants
            if (e.Action != TreeViewAction.Unknown && e.Node.Checked && e.Node == kryptonTreeView1.Nodes[1])
            {
                for (int i = 0; i < 7; i++)
                    kryptonTreeView1.Nodes[1].Nodes[i].Checked = true;
            }
            else if (e.Action != TreeViewAction.Unknown && !e.Node.Checked && e.Node == kryptonTreeView1.Nodes[1])
            {
                for (int i = 0; i < 7; i++)
                    kryptonTreeView1.Nodes[1].Nodes[i].Checked = false;
            }

            //SLAE
            if (e.Action != TreeViewAction.Unknown && e.Node.Checked && e.Node == kryptonTreeView1.Nodes[2])
            {
                for (int i = 0; i < 9; i++)
                    kryptonTreeView1.Nodes[2].Nodes[i].Checked = true;
            }
            else if (e.Action != TreeViewAction.Unknown && !e.Node.Checked && e.Node == kryptonTreeView1.Nodes[2])
            {
                for (int i = 0; i < 9; i++)
                    kryptonTreeView1.Nodes[2].Nodes[i].Checked = false;
            }

            //Analytic Geometry
            if (e.Action != TreeViewAction.Unknown && e.Node.Checked && e.Node == kryptonTreeView1.Nodes[3])
            {
                for (int i = 0; i < 10; i++)
                    kryptonTreeView1.Nodes[3].Nodes[i].Checked = true;
            }
            else if (e.Action != TreeViewAction.Unknown && !e.Node.Checked && e.Node == kryptonTreeView1.Nodes[3])
            {
                for (int i = 0; i < 10; i++)
                    kryptonTreeView1.Nodes[3].Nodes[i].Checked = false;
            }
        }
    }
}
