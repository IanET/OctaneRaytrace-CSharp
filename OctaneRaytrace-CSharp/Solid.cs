using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctaneRaytrace_CSharp
{
    public class Solid : BaseMaterial
    {
        Color color;

        public Solid(Color color, double reflection, double refraction, double transparency, double gloss)
        {
            this.color = color;
            this.reflection = reflection;
            this.transparency = transparency;
            this.gloss = gloss;
            this.hasTexture = false;
        }

        public override Color getColor(double u, double v)
        {
            return this.color;
        }

        public override String toString()
        {
            return "SolidMaterial [gloss=" + this.gloss + ", transparency=" + this.transparency + ", hasTexture=" + this.hasTexture + "]";
        }
    }
}
