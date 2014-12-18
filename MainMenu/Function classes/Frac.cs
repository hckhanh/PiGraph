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
    class Frac : Input
    {
        public Frac()
        {
            arrPoints = new List<PointF>();
            List<float> arrParameters = new List<float>();
            type = 0;
        }

        public override void DrawFunc(ref OpenGL gl)
        {
            //tam doi xung
            PointF I = new PointF((-arrParameters[3] / arrParameters[2]), (arrParameters[0] / arrParameters[2]));

            float tmp;
            float incr = 1.0F / scale;
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.PointSize(DepthLine);
            gl.Begin(OpenGL.GL_POINTS);

            //khi tri tuyet he so goc cua tiep tuyen >= 1
            for (float i = -(float)Root.X / scale; i < (float)(gl.RenderContextProvider.Width - Root.X) / scale; i += incr)
            {
                if (i != -arrParameters[3] / arrParameters[2])
                {
                    tmp = (arrParameters[0] * i + arrParameters[1]) / (arrParameters[2] * i + arrParameters[3]);
                    gl.Vertex(i * scale + Root.X, tmp * scale + Root.Y);
                    //lay doi xung
                    gl.Vertex((2 * I.X - i) * scale + Root.X, (2 * I.Y - tmp) * scale + Root.Y);
                }
            }
            //khi tri tuyet he so goc cua tiep tuyen < 1
            for (float i = -(float)Root.Y / scale; i < (float)(gl.RenderContextProvider.Height - Root.Y) / scale; i += incr)
            {
                if (i != arrParameters[0] / arrParameters[2])
                {
                    tmp = (arrParameters[3] * i - arrParameters[1]) / (-arrParameters[2] * i + arrParameters[0]);
                    gl.Vertex(tmp * scale + Root.X, i * scale + Root.Y);
                }
            }
            gl.End();
        }

        public override void DrawFuncAbs(ref OpenGL gl)
        {
            //tam doi xung
            PointF I = new PointF((-arrParameters[3] / arrParameters[2]), (arrParameters[0] / arrParameters[2]));

            float tmp;
            float incr = 1.0F / scale;
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.PointSize(1.5F);
            gl.Begin(OpenGL.GL_POINTS);
            //khi tri tuyet he so goc cua tiep tuyen >= 1
            for (float i = -(float)Root.X / scale; i < (float)(gl.RenderContextProvider.Width - Root.X) / scale; i += incr)
            {
                if (i != -arrParameters[3] / arrParameters[2])
                {
                    tmp = (arrParameters[0] * i + arrParameters[1]) / (arrParameters[2] * i + arrParameters[3]);
                    gl.Vertex(i * scale + Root.X, Math.Abs(tmp * scale) + Root.Y);
                    //lay doi xung
                    gl.Vertex((2 * I.X - i) * scale + Root.X, Math.Abs((2 * I.Y - tmp) * scale) + Root.Y);
                }
            }
            //khi tri tuyet he so goc cua tiep tuyen < 1
            float min = -(float)Root.Y / scale;
            float max = (float)(gl.RenderContextProvider.Height - Root.Y) / scale;
            for (float i = min; i < max; i += incr)
            {
                if (i != arrParameters[0] / arrParameters[2])
                {
                    tmp = (arrParameters[3] * i - arrParameters[1]) / (-arrParameters[2] * i + arrParameters[0]);
                    gl.Vertex(tmp * scale + Root.X, Math.Abs(i * scale) + Root.Y);
                }
            }
            for (float i = -max; i < -min; i += incr)
            {
                if (i != arrParameters[0] / arrParameters[2])
                {
                    tmp = (arrParameters[3] * i - arrParameters[1]) / (-arrParameters[2] * i + arrParameters[0]);
                    gl.Vertex(tmp * scale + Root.X, Math.Abs(i * scale) + Root.Y);
                }
            }
            gl.End();
        }

        public override void DrawFuncXAbs(ref OpenGL gl)
        {
            //tam doi xung
            PointF I = new PointF((-arrParameters[3] / arrParameters[2]), (arrParameters[0] / arrParameters[2]));

            float tmp, tmp2;
            float xmax = (float)(gl.RenderContextProvider.Width - Root.X) / scale;
            float ymax = (float)(gl.RenderContextProvider.Height - Root.Y) / scale;
            float incr = 1.0F / scale;
            gl.PointSize(2);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.Begin(OpenGL.GL_POINTS);
            //khi tri tuyet he so goc cua tiep tuyen >= 1
            for (float i = -(float)Root.X / scale; i < xmax; i += incr)
            {
                tmp2 = Math.Abs(i);
                if (i != -arrParameters[3] / arrParameters[2])
                {
                    tmp = (arrParameters[0] * tmp2 + arrParameters[1]) / (arrParameters[2] * tmp2 + arrParameters[3]);
                    gl.Vertex(tmp2 * scale + Root.X, tmp * scale + Root.Y);
                    //lay doi xung
                    gl.Vertex(-tmp2 * scale + Root.X, tmp * scale + Root.Y);
                }
            }
            //khi tri tuyet he so goc cua tiep tuyen < 1
            for (float i = -(float)Root.Y / scale; i < ymax; i += incr)
            {
                if (i != arrParameters[0] / arrParameters[2])
                {
                    tmp = (arrParameters[3] * i - arrParameters[1]) / (-arrParameters[2] * i + arrParameters[0]);
                    if (tmp >= 0)
                    {
                        gl.Vertex(tmp * scale + Root.X, i * scale + Root.Y);
                        gl.Vertex(-tmp * scale + Root.X, i * scale + Root.Y);
                    }
                }
            }
            gl.End();
        }
        
        public override void DrawShape(ref OpenGL gl)
        {
            FindSpecialPoint(ref gl);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);
            gl.Enable(OpenGL.GL_LINE_STIPPLE);
            gl.LineStipple(1, 0x00FF);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(arrPoints[0].X, arrPoints[0].Y);
            gl.Vertex(arrPoints[1].X, arrPoints[1].Y);
            gl.Vertex(arrPoints[2].X, arrPoints[2].Y);
            gl.Vertex(arrPoints[3].X, arrPoints[3].Y);
            if (type == 2)
            {
                gl.Vertex(arrPoints[4].X, arrPoints[4].Y);
                gl.Vertex(arrPoints[5].X, arrPoints[5].Y);
            }
            gl.End();
            gl.Disable(OpenGL.GL_LINE_STIPPLE);
        }

        public override void FindSpecialPoint(ref OpenGL gl)
        {
            arrPoints.Clear();
            arrPoints.Add(new PointF(-arrParameters[3] / arrParameters[2] * scale + Root.X, 0));
            arrPoints.Add(new PointF(-arrParameters[3] / arrParameters[2] * scale + Root.X, gl.RenderContextProvider.Height));
            arrPoints.Add(new PointF(0, arrParameters[0] / arrParameters[2] * scale + Root.Y));
            arrPoints.Add(new PointF(gl.RenderContextProvider.Width, arrParameters[0] / arrParameters[2] * scale + Root.Y));
            if (type == 2)
            {
                arrPoints.Add(new PointF(arrParameters[3] / arrParameters[2] * scale + Root.X, 0));
                arrPoints.Add(new PointF(arrParameters[3] / arrParameters[2] * scale + Root.X, gl.RenderContextProvider.Height));
            }
        }
    }
}
