using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctaneRaytrace_CSharp
{
    public abstract class BaseShape
    {
        public Vector3D position;
        public BaseMaterial material;

        public abstract IntersectionInfo intersect(Ray ray);
    }
}
