using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;

namespace PixelsGraph
{
    class Logarit : Input
    {
        public Logarit()
        {
            arrPoints = new List<PointF>();
            arrParameters = new List<float>();
        }

        public override void DrawFuncAbs(ref OpenGL gl)
        {
            gl.LineWidth(DepthLine);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            float max = (float)(gl.RenderContextProvider.Height - Root.Y) / scale;
            float min = -(float)Root.Y / scale;
            double dy = 1.0d / scale;
            double y = min;
            double x = Math.Pow(arrParameters[0], y);
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (double)(Math.Abs(y) * scale);
            double x2, y2;

            gl.Begin(OpenGL.GL_LINES);
            while (y < max)
            {
                y += dy;
                x = Math.Pow(arrParameters[0], y);
                x2 = Root.X + (double)(x * scale);
                y2 = Root.Y + (double)(Math.Abs(y) * scale);
               
                gl.Vertex(x1, y1);
                gl.Vertex(x2, y2);

                x1 = x2;
                y1 = y2;
            }

            y = -max;
            x = Math.Pow(arrParameters[0], y);
            x1 = Root.X + (double)(x * scale);
            y1 = Root.Y + (double)(Math.Abs(y) * scale);
            while (y < -min)
            {
                y += dy;
                x = Math.Pow(arrParameters[0], y);
                x2 = Root.X + (double)(x * scale);
                y2 = Root.Y + (double)(Math.Abs(y) * scale);

                gl.Vertex(x1, y1);
                gl.Vertex(x2, y2);

                x1 = x2;
                y1 = y2;
            }

            gl.End();
            gl.Flush();
        }

        public override void DrawFunc(ref OpenGL gl)
        {
            gl.LineWidth(2);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            float max = (float)(gl.RenderContextProvider.Height - Root.Y) / scale;
            float min = -(float)Root.Y / scale;
            double dy = 1.0d / scale;

            double y = min;
            double x = Math.Pow(arrParameters[0], y);
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (float)(y * scale);

            double x2, y2;
            while (y < max)
            {
                y += dy;
                x = Math.Pow(arrParameters[0], y);
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

        public override void DrawFuncXAbs(ref OpenGL gl)
        {
            gl.LineWidth(2);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            int max = (gl.RenderContextProvider.Height - Root.Y) / scale + 1;
            int min = -Root.Y / scale - 1;
            double dy = 1.0d / scale;

            double y = min;
            double x = Math.Pow(arrParameters[0], y);
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (float)(y * scale);
            double x3 = Root.X + (double)(-x * scale);
            double y3 = Root.Y + (float)(y * scale);

            double x2, y2, x4, y4;
            while (y < max)
            {
                y += dy;
                x = Math.Pow(arrParameters[0], y);
                x2 = Root.X + (float)(x * scale);
                y2 = Root.Y + (float)(y * scale);
                x4 = Root.X + (float)(-x * scale);
                y4 = Root.Y + (float)(y * scale);
                gl.Vertex(x1, y1);
                gl.Vertex(x2, y2);

                gl.Vertex(x3, y3);
                gl.Vertex(x4, y4);

                x1 = x2;
                y1 = y2;
                x3 = x4;
                y3 = y4;
            }
            gl.End();
            gl.Flush();
        }
    }
}