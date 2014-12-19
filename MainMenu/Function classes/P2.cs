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
    class P2 : Input
    {
        public P2()
        {
            arrPoints = new List<PointF>();
            arrParameters = new List<float>();
            type = 0;
        }

        public override void DrawFunc(ref OpenGL gl)
        {
            double a = arrParameters[0];
            double b = arrParameters[1];
            double c = arrParameters[2];

            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            // Vẽ theo chiều ngang

            for (double x = -(double)Root.X / scale; x < (double)(gl.RenderContextProvider.Width - Root.X) / scale; x += 1.0f / scale)
            {
                double y = a * x * x + b * x + c;

                if (x * scale + Root.X >= 0
                    && x * scale + Root.X <= gl.RenderContextProvider.Width)
                    gl.Vertex(x * scale + Root.X, y * scale + Root.Y);
            }

            gl.End();
            gl.Flush();
        }

        public override void DrawFuncAbs(ref OpenGL gl)
        {
            double a = arrParameters[0];
            double b = arrParameters[1];
            double c = arrParameters[2];

            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            // Vẽ theo chiều ngang

            for (double x = -(double)Root.X / scale; x < (double)(gl.RenderContextProvider.Width - Root.X) / scale; x += 1.0f / scale)
            {
                double y = Math.Abs(a * x * x + b * x + c);

                if (x * scale + Root.X >= 0
                    && x * scale + Root.X <= gl.RenderContextProvider.Width)
                    gl.Vertex(x * scale + Root.X, y * scale + Root.Y);
            }

            gl.End();
            gl.Flush();
        }

        public override void DrawFuncXAbs(ref OpenGL gl)
        {
            double a = arrParameters[0];
            double b = arrParameters[1];
            double c = arrParameters[2];

            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            // Vẽ theo chiều ngang

            for (double x = -(double)Root.X / scale; x < (double)(gl.RenderContextProvider.Width - Root.X) / scale; x += 1.0f / scale)
            {
                double y = a * x * x + b * Math.Abs(x) + c;

                if (x * scale + Root.X >= 0
                    && x * scale + Root.X <= gl.RenderContextProvider.Width)
                    gl.Vertex(x * scale + Root.X, y * scale + Root.Y);
            }

            gl.End();
            gl.Flush();
        }

        public List<double> sovleP2(List<double> arrPars)
        {
            List<double> x = new List<double>();

            double a = arrPars[0];
            double b = arrPars[1];
            double c = arrPars[2];

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                double delta_2 = Math.Sqrt(delta);
                double x1 = (-b - delta_2) / (2 * a);
                double x2 = (-b + delta_2) / (2 * a);

                x.Add(x1);
                x.Add(x2);
            }

            return x;
        }

        //ve tiep tuyen
        public override void DrawTangentialLine(Point TangentialPoint, OpenGL gl)
        {
            P1 myLine = new P1();
            List<float> arrParameters_P1 = new List<float>();
            float f_ = 2 * (float)arrParameters[0] * TangentialPoint.X + (float)arrParameters[1];//tính đạo hàm
            arrParameters_P1.Add(f_);//tham số a đường thẳng
            arrParameters_P1.Add(f_ * -1 * TangentialPoint.X + TangentialPoint.Y);//b
            myLine.Draw(gl);
        }

        public override PointF TangentialLine(Point TangentialPoint, OpenGL gl)
        {
            PointF tmp = new PointF();
            tmp.X = 2 * (float)arrParameters[0] * TangentialPoint.X + (float)arrParameters[1];//tính đạo hàm
            tmp.Y = tmp.X * -1 * TangentialPoint.X + TangentialPoint.Y;//b
            return tmp;
        }

        /// <summary>
        /// Tìm các điểm đặc biệt
        /// </summary>
        /// <param name="des">danh sách điểm đặc biệt được thêm vào</param>
        protected override void addSpecialPoint()
        {
            specialPoint.Clear();

            PointF tmp = new PointF();
            tmp.X = -arrParameters[1] / (2 * arrParameters[0]);
            tmp.Y = arrParameters[0] * tmp.X * tmp.X + arrParameters[1] * tmp.X + arrParameters[2];
            tmp.X = tmp.X * scale + Root.X;
            tmp.Y = tmp.Y * scale + Root.Y;
            specialPoint.Add(tmp);
        }
    }
}