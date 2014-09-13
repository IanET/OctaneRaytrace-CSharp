using System;

namespace OctaneRaytrace_CSharp
{
    public abstract class BaseMaterial
    {
        public double gloss = 2.0;             // [0...infinity] 0 = matt
        public double transparency = 0.0;      // 0=opaque
        public double reflection = 0.0;        // [0...infinity] 0 = no reflection
        public double refraction = 0.50;
        public bool hasTexture = false;

        public abstract Color getColor(double u, double v);

        public double wrapUp(double t)
        {
            t = t % 2.0;
            if (t < -1) t += 2.0;
            if (t >= 1) t -= 2.0;
            return t;
        }

        public virtual String toString()
        {
            return "Material [gloss=" + this.gloss + ", transparency=" + this.transparency + ", hasTexture=" + this.hasTexture + "]";
        }
    }
}
