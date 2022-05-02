using System.IO;
using System.Drawing;
using System.Windows.Media.Imaging;
using WpfMath;

namespace WpfControlLibrary1
{
    public class LatexHandler
    {
        public Bitmap CreateLatexImage(string latex)
        {
            TexFormulaParser parser = new TexFormulaParser();
            TexFormula formula = parser.Parse(latex);
            MemoryStream stream = new MemoryStream(formula.RenderToPng(18.0, 0, 0, "Arial"));
            return new Bitmap(stream);
        }
    }
}
