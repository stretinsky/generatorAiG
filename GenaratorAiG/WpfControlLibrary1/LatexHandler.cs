using System.IO;
using System.Windows.Media.Imaging;
using WpfMath;

namespace WpfControlLibrary1
{
    public class LatexHandler
    {
        public string CreateLatexImage(string latex)
        {
            string workFile = "tempLatex.png";
            File.Open(workFile, FileMode.OpenOrCreate).Close();

            var parser = new TexFormulaParser();

            var formula = parser.Parse(latex);
            var renderer = formula.GetRenderer(TexStyle.Display, 20.0, "Arial");
            var bitmapSource = renderer.RenderToBitmap(0, 0);

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
            using (var target = new FileStream(workFile, FileMode.Create))
            {
                encoder.Save(target);
            }
            return workFile;
        }
    }
}
