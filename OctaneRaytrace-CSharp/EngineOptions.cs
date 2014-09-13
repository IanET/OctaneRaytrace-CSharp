using System;

namespace OctaneRaytrace_CSharp
{
    public class EngineOptions
    {
        public int canvasHeight = 100;
        public int canvasWidth = 100;
        public int pixelWidth = 2;
        public int pixelHeight = 2;
        public bool renderDiffuse = false;
        public bool renderShadows = false;
        public bool renderHighlights = false;
        public bool renderReflections = false;
        public int rayDepth = 2;
    }
}
