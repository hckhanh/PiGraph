using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using SharpGL;

namespace PixelsGraph
{
    class Cos : Input
    {
        public Cos()
        {
            arrPoints = new List<PointF>();
            arrParameters = new List<float>();
        }

        public override void DrawFunc(ref OpenGL gl)
        {
            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A /255.0);

            int max = (gl.RenderContextProvider.Width - Root.X) / scale + 1;
            int min = - Root.X / scale - 1;
            double dx = 1.0d / scale;
        
            double x = min;
            double y = arrParameters[0] * Math.Cos(arrParameters[1] * x + arrParameters[2]) + arrParameters[3];
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (float)(y * scale);

            double x2, y2;
            while (x < max)
            {
                x += dx;
                y = arrParameters[0] * Math.Cos(arrParameters[1] * x + arrParameters[2]) + arrParameters[3];
                
                x2 = Root.X + (float)(x * scale);
                y2 = Root.Y + (float)(y * scale);

                gl.Vertex(x1, y1);
                gl.Vertex(x2, y2);

                x1 = x2;
                y1 = y2;
            }
            gl.End();
            gl.Flush();
        }

        public override void DrawFuncAbs(ref OpenGL gl)
        {
            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            int max = (gl.RenderContextProvider.Width - Root.X) / scale + 1;
            int min = -Root.X / scale - 1;
            double dx = 1.0d / scale;

            double x = min;
            double y = arrParameters[0] * Math.Cos(arrParameters[1] * x + arrParameters[2]) + arrParameters[3];
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + Math.Abs((float)(y * scale));

            double x2, y2;
            while (x < max)
            {
                x += dx;
                y = arrParameters[0] * Math.Cos(arrParameters[1] * x + arrParameters[2]) + arrParameters[3];

                x2 = Root.X + (float)(x * scale);
                y2 = Root.Y + (float)Math.Abs((y * scale));

                gl.Vertex(x1, y1);
                gl.Vertex(x2, y2);

                x1 = x2;
                y1 = y2;
            }
            gl.End();
            gl.Flush();
        }

        public override void DrawFuncXAbs(ref OpenGL gl)
        {
            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            int max = (gl.RenderContextProvider.Width - Root.X) / scale + 1;
            int min = -Root.X / scale - 1;
            double dx = 1.0d / scale;

            double x = min;
            double y = arrParameters[0] * Math.Cos(arrParameters[1] * Math.Abs(x) + arrParameters[2]) + arrParameters[3];
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (float)(y * scale);

            double x2, y2;
            while (x < max)
            {
                x += dx;
                y = arrParameters[0] * Math.Cos(arrParameters[1] * Math.Abs(x) + arrParameters[2]) + arrParameters[3];

                x2 = Root.X + (float)(x * scale);
                y2 = Root.Y + (float)(y * scale);

                gl.Vertex(x1, y1);
                gl.Vertex(x2, y2);

                x1 = x2;
                y1 = y2;
            }
            gl.End();
            gl.Flush();
        }
    }
}
