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
    class P4 : Input
    {
        public P4()
        {
            arrPoints = new List<PointF>();
            arrParameters = new List<float>();
            type = 0;
        }

        //private P1 Tangential = null;

        public override void DrawFunc(ref OpenGL gl)
        {
            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            int max = (gl.RenderContextProvider.Width - Root.X) / scale + 1;
            int min = -Root.X / scale - 1;
            double dx = 1.0d / scale;
        
            double x = min;
            double y = arrParameters[0] * x * x * x * x + arrParameters[1] * x * x + arrParameters[2];
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + (float)(y * scale);
            
            double x2, y2;
            while (x < max)
            {
                x += dx;
                y = arrParameters[0] * x * x * x * x + arrParameters[1] * x * x + arrParameters[2];

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

            double max = (double)(gl.RenderContextProvider.Width - Root.X) / scale;
            double min = (double)-Root.X / scale;
            double dx = 0.5d / scale;

            double x = min;
            double y = arrParameters[0] * x * x * x * x + arrParameters[1] * x * x + arrParameters[2];
            double x1 = Root.X + (double)(x * scale);
            double y1 = Root.Y + Math.Abs((double)(y * scale));

            double x2, y2;
            while (x < max)
            {
                x += dx;
                y = arrParameters[0] * x * x * x * x + arrParameters[1] * x * x + arrParameters[2];

                x2 = Root.X + (double)(x * scale);
                y2 = Root.Y + Math.Abs((double)(y * scale));

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
            DrawFunc(ref gl);
        }

        public override void DrawTangentialLine(Point TangentialPoint, OpenGL gl)
        {
            P1 myLine = new P1();
            List<float> arrParameters_P1 = new List<float>();
            float f_ = 4 * (float)arrParameters[0] * TangentialPoint.X * TangentialPoint.X * TangentialPoint.X + 2 * (float)arrParameters[1] * TangentialPoint.X;//tính đạo hàm
            arrParameters_P1.Add(f_);//tham số a đường thẳng
            arrParameters_P1.Add(f_ * -1 * TangentialPoint.X + TangentialPoint.Y);//b
            myLine.Draw(gl);
        }

        public override PointF TangentialLine(Point TangentialPoint, OpenGL gl)
        {
            PointF tmp = new PointF();
            tmp.X = 4 * (float)arrParameters[0] * TangentialPoint.X * TangentialPoint.X * TangentialPoint.X + 2 * (float)arrParameters[1] * TangentialPoint.X;//tính đạo hàm
            tmp.Y = tmp.X * -1 * TangentialPoint.X + TangentialPoint.Y;
            return tmp;
        }

        /// <summary>
        /// Tìm các điểm đặc biệt
        /// </summary>
        protected override void addSpecialPoint()
        {
            specialPoint.Clear();

            PointF tmp = new PointF();
            tmp.X = 0;
            tmp.Y = arrParameters[0] * tmp.X * tmp.X * tmp.X * tmp.X + arrParameters[1] * tmp.X * tmp.X + arrParameters[2];
            tmp.X = tmp.X * scale + Root.X;
            tmp.Y = tmp.Y * scale + Root.Y;
            specialPoint.Add(tmp);

            if (arrParameters[1] < 0)
            {
                tmp.X = (float)Math.Sqrt(-arrParameters[1] / (2 * arrParameters[0]));
                tmp.Y = arrParameters[0] * tmp.X * tmp.X * tmp.X * tmp.X + arrParameters[1] * tmp.X * tmp.X + arrParameters[2];
                tmp.X = tmp.X * scale + Root.X;
                tmp.Y = tmp.Y * scale + Root.Y;
                specialPoint.Add(tmp);

                tmp.X = -(float)Math.Sqrt(-arrParameters[1] / (2 * arrParameters[0]));
                tmp.Y = arrParameters[0] * tmp.X * tmp.X * tmp.X * tmp.X + arrParameters[1] * tmp.X * tmp.X + arrParameters[2];
                tmp.X = tmp.X * scale + Root.X;
                tmp.Y = tmp.Y * scale + Root.Y;
                specialPoint.Add(tmp);
            }
        }
    }
}
