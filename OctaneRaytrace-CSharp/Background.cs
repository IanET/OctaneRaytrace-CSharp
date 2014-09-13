using System;

namespace OctaneRaytrace_CSharp
{
     public class Background {
        public Color color;
        public double ambience;

        public Background(Color color, double ambience) {
            this.color = color;
            this.ambience = ambience;
        }
    }
}
