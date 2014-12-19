using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;


namespace PixelsGraph
{
    class P1 : Input
    {
        public P1()
        {
            arrPoints = new List<PointF>();
            arrParameters = new List<float>();
            type = 0;
        }

        public override void DrawFunc(ref OpenGL gl)
        {
            gl.LineWidth(DepthLine);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.Begin(OpenGL.GL_LINES);

            double max = (double)(gl.RenderContextProvider.Width - Root.X) / scale;
            double min = -(double)Root.X / scale;
     
            double x = min;
            double y = arrParameters[0] * x + arrParameters[1];
            
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (float)(y * scale);

            x = max;
            y = arrParameters[0] * x + arrParameters[1];

            double x2 = Root.X + (double)(x * scale);
            double y2 = Root.Y + (float)(y * scale);

            gl.Vertex(x1, y1);
            gl.Vertex(x2, y2);

            gl.End();
            gl.Flush();
        }

        public override void DrawFuncAbs(ref OpenGL gl)
        {
            gl.LineWidth(2);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.Begin(OpenGL.GL_LINE_STRIP);

            double x, y, x1, y1, x2, y2, x3;

            double max = (double)(gl.RenderContextProvider.Width - Root.X) / scale;
            double min = (double)-Root.X / scale;

            x = min;
            y = arrParameters[0] * x + arrParameters[1];

            x1 = Root.X + (double)(x * scale);
            y1 = Root.Y + Math.Abs((float)(y * scale));

            x = max;
            y = arrParameters[0] * x + arrParameters[1];

            x2 = Root.X + (double)(x * scale);
            y2 = Root.Y + Math.Abs((float)(y * scale));

            x3 = -arrParameters[1] / arrParameters[0];

            gl.Vertex(x1, y1);
            if (x3 > min && x3 < max)
                gl.Vertex(Root.X + x3 * scale, Root.Y);
            gl.Vertex(x2, y2);

            gl.End();
            gl.Flush();
        }

        public override void DrawFuncXAbs(ref OpenGL gl)
        {
            gl.LineWidth(2);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.Begin(OpenGL.GL_LINE_STRIP);

            double max = (double)(gl.RenderContextProvider.Width - Root.X) / scale;
            double min = (double)-Root.X / scale;

            double x, y, x1, y1, x2, y2, x3;

            if (min < 0)
                min = 0;
            if (Math.Abs(-Root.X / scale - 1) > max)
                max = Math.Abs(-Root.X / scale - 1);

            x = min;
            y = arrParameters[0] * Math.Abs(x) + arrParameters[1];

            x1 = Root.X + (double)(x * scale);
            y1 = Root.Y + (float)(y * scale);

            x = max;
            y = arrParameters[0] * Math.Abs(x) + arrParameters[1];

            x2 = Root.X + (double)(x * scale);
            y2 = Root.Y + (float)(y * scale);

            x3 = Root.X + (double)(-x * scale);

            gl.Vertex(x3, y2);
            gl.Vertex(x1, y1);
            gl.Vertex(x2, y2);

            gl.End();
            gl.Flush();
        }
    }
}
