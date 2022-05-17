using System.IO;
using System.Drawing;
using WpfMath;

namespace Latex
{
    public class LatexImageBuilder
    {
        private string font = "Arial";
        private float fontSize = 18;
        public Bitmap CreateLatexImage(string latex)
        {
            TexFormulaParser parser = new TexFormulaParser();
            TexFormula formula = parser.Parse(latex);
            MemoryStream stream = new MemoryStream(formula.RenderToPng(fontSize, 0, 0, font));
            return new Bitmap(stream);
        }
    }
}
