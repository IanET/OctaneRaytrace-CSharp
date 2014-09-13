using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctaneRaytrace_CSharp
{
    public class Chessboard : BaseMaterial
    {
        Color colorEven;
        Color colorOdd;
        double density = 0.5;

        public Chessboard(Color colorEven, Color colorOdd, double reflection, double transparency, double gloss, double density)
        {
            this.colorEven = colorEven;
            this.colorOdd = colorOdd;
            this.reflection = reflection;
            this.transparency = transparency;
            this.gloss = gloss;
            this.density = density;
            this.hasTexture = true;
        }

        public override Color getColor(double u, double v)
        {
            double t = this.wrapUp(u * this.density) * this.wrapUp(v * this.density);
            if (t < 0.0)
                return this.colorEven;
            else
                return this.colorOdd;
        }

        public override String toString()
        {
            return "ChessMaterial [gloss=" + this.gloss + ", transparency=" + this.transparency + ", hasTexture=" + this.hasTexture + "]";
        }
    }

}
