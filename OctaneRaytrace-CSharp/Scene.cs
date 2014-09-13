using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctaneRaytrace_CSharp
{
    public class Scene
    {
        public Camera camera;
        public List<BaseShape> shapes;
        public List<Light> lights;
        public Background background;

        public Scene()
        {
            this.camera = new Camera(new Vector3D(0, 0, -5), new Vector3D(0, 0, 1), new Vector3D(0, 1, 0));
            this.shapes = new List<BaseShape>();
            this.lights = new List<Light>();
            this.background = new Background(new Color(0, 0, 0.5), 0.2);
        }
    }
}
