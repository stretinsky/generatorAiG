using System.Drawing;
using IronPdf;
using Latex;
using System;
using System.Collections.Generic;

namespace GenaratorAiG
{
    class PdfBuilder
    {
        private LatexImageBuilder latexHandler = new LatexImageBuilder();
        private string html;
        private int number = 0, various = 0;
        private double fontSize = 20;
        private string font = "TimesNewRoman";

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Various
        {
            get { return various; }
            set { various = value; }
        }

        public void HandleTask(string conditionPre, string[] latex)
        {
            //Номер задания
            number++;
            string condition = number.ToString() + ". " + conditionPre;

            int count = 0;
            foreach (char c in condition)
                if (c == '$') count++;
            if (count == 0)
            {
                Bitmap img = latexHandler.CreateLatexImage(latex[0]);
                string imgDataURI = IronPdf.Imaging.ImageUtilities.ImageToDataUri(img);
                string imgHtml = string.Format("<img src='{0}' width ='{1}' height='{2}'>", imgDataURI, img.Width, img.Height);
                html += $"<p style='font-size:{fontSize};font-family:{font};'>{condition.Trim()} <br>{imgHtml}</p>";
                img.Dispose();
            }
            else if (count == latex.Length)
            {
                condition = condition.Replace("\n", "<br>");
                string[] splittedCondition = condition.Split('$');
                html += $"<p style='font-size:{fontSize};font-family:{font};'> {splittedCondition[0].Trim()}";
                for (int i = 0; i < count; i++)
                {
                    Bitmap img = latexHandler.CreateLatexImage(latex[i]);
                    string imgDataURI = IronPdf.Imaging.ImageUtilities.ImageToDataUri(img);
                    string imgHtml = string.Format("&nbsp<img src='{0}' width='{1}' height='{2}' align='absmiddle'>&nbsp;", imgDataURI, img.Width, img.Height);
                    img.Dispose();
                    html += imgHtml + splittedCondition[i + 1].Trim();
                }
                html += "</p>";
            }
            else if (count + 1 == latex.Length)
            {
                condition = condition.Replace("\n", "<br>");
                string[] splittedCondition = condition.Split('$');
                html += $"<p style='font-size:{fontSize};font-family:{font};'> {splittedCondition[0].Trim()}";
                Bitmap img;
                string imgDataURI, imgHtml;
                for (int i = 0; i < count; i++)
                {
                    img = latexHandler.CreateLatexImage(latex[i]);
                    imgDataURI = IronPdf.Imaging.ImageUtilities.ImageToDataUri(img);
                    imgHtml = string.Format("&nbsp<img src='{0}' width='{1}' height='{2}' align='absmiddle'>&nbsp;", imgDataURI, img.Width, img.Height);
                    img.Dispose();
                    html += imgHtml + splittedCondition[i + 1].Trim();
                }
                img = latexHandler.CreateLatexImage(latex[latex.Length - 1]);
                imgDataURI = IronPdf.Imaging.ImageUtilities.ImageToDataUri(img);
                imgHtml = string.Format("&nbsp<img src='{0}' width='{1}' height='{2}' align='absmiddle'>&nbsp;", imgDataURI, img.Width, img.Height);
                html += imgHtml;
                html += "</p>";
            }
            else
                throw new Exception("Кол-во $ должно быть либо на одно 1 меньше, чем число латех форм, либо равно этому числу");
        }
        public void HandleTask(string condition, string latex)
        {
            HandleTask(condition, new string[] { latex });
        }
        public void HandleTask(string condition, List<string> latex)
        {
            HandleTask(condition, latex.ToArray());
        }
        public void ShowAnswer(string answerPre, bool increment = true)
        {
            if (increment) number++;
            string answer;
            if (increment) answer = number.ToString() + ". " + answerPre;
            else answer = answerPre;

            Bitmap img = latexHandler.CreateLatexImage(answer);
            string imgDataURI = IronPdf.Imaging.ImageUtilities.ImageToDataUri(img);
            string imgHtml = string.Format("<img src='{0}' width ='{1}' height='{2}'>", imgDataURI, img.Width, img.Height);
            html += $"<p style='font-size:{fontSize};font-family:{font};'>{imgHtml}</p>";
            img.Dispose();
        }
        public void GeneratePdf(string path)
        {
            var Renderer = new ChromePdfRenderer();
            var pdf = Renderer.RenderHtmlAsPdf(html);
            pdf.SaveAs(path);
            pdf.Dispose();
        }

        public string GetHTML()
        {
            return html;
        }

        public void WriteVariant()
        {
            html += $"<center>Вариант {various}</center>";            
        }

        public void ClearHtml()
        {
            html = "";
        }

    }
}
