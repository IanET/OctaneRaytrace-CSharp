using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctaneRaytrace_CSharp
{
    public class Ray {
        public Vector3D position;
        public Vector3D direction;

        public Ray(Vector3D pos, Vector3D dir) {
            this.position = pos;
            this.direction = dir;
        }

        public String toString() {
            return "Ray [" + this.position + "," + this.direction + "]";
        }
    }
}
