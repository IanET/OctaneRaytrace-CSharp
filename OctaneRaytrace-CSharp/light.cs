using System;

namespace OctaneRaytrace_CSharp
{
    public class Light {
        public Vector3D position;
        public Color color;
        double intensity;

        public Light(Vector3D pos, Color color, double intensity) {
            this.position = pos;
            this.color = color;
            this.intensity = intensity;
        }

        public Light(Vector3D pos, Color color) {
            this.position = pos;
            this.color = color;
            this.intensity = 10.0;
        }

        public String toString() {
            return "Light [" + this.position.x + "," + this.position.y + "," + this.position.z + "]";
        }
    }
}