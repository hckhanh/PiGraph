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
    class P3 : Input
    {
        public P3()
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
            double d = arrParameters[3];

            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            // Vẽ theo chiều ngang

            for (double x = -(double)Root.X / scale; x < (double)(-Root.X + gl.RenderContextProvider.Width) / scale; x += 1.0f / scale)
            {
                double y = a * x * x * x + b * x * x + c * x + d;

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
            double d = arrParameters[3];

            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            // Vẽ theo chiều ngang

            for (double x = -(double)Root.X / scale; x < (double)(-Root.X + gl.RenderContextProvider.Width) / scale; x += 1.0f / scale)
            {
                double y = Math.Abs(a * x * x * x + b * x * x + c * x + d);

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
            double d = arrParameters[3];

            gl.LineWidth(DepthLine);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Color(clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            // Vẽ theo chiều ngang

            for (double x = -(double)Root.X / scale; x < (double)(-Root.X + gl.RenderContextProvider.Width) / scale; x += 1.0f / scale)
            {
                double y = a * Math.Abs(x * x * x) + b * x * x + c * Math.Abs(x) + d;

                if (x * scale + Root.X >= 0
                    && x * scale + Root.X <= gl.RenderContextProvider.Width)
                    gl.Vertex(x * scale + Root.X, y * scale + Root.Y);


            }

            gl.End();
            gl.Flush();
        }

        public List<double> sovleP3(List<double> arrPars)
        {
            List<double> x = new List<double>();

            double a = arrPars[0];
            double b = arrPars[1];
            double c = arrPars[2];
            double d = arrPars[3];


            double delta = b * b - 3 * a * c;
            double k_tu = 9 * a * b * c - 2 * b * b * b - 27 * a * a * d;
            double k_mau = 2 * Math.Sqrt(Math.Pow(Math.Abs(delta), 3));
            double k = k_tu / k_mau;

            if (delta > 0)
            {
                if (Math.Abs(k) <= 1)
                {
                    double delta_2 = Math.Sqrt(delta);
                    double cos = Math.Acos(k) / 3;

                    double x1 = (2 * delta_2 * Math.Cos(cos) - b) / (3 * a);
                    double x2 = (2 * delta_2 * Math.Cos(cos - 2 * Math.PI / 3) - b) / (3 * a);
                    double x3 = (2 * delta_2 * Math.Cos(cos + 2 * Math.PI / 3) - b) / (3 * a);

                    x.Add(x1);
                    x.Add(x2);
                    x.Add(x3);
                }
                else
                {
                    double can_truoc = Math.Pow(Math.Abs(k) + Math.Sqrt(k * k - 1), 1.0f / 3);
                    double can_sau = Math.Pow(Math.Abs(k) - Math.Sqrt(k * k - 1), 1.0f / 3);

                    double x1 = Math.Sqrt(Math.Abs(delta)) * Math.Abs(k) / (3 * a * k) * (can_truoc + can_sau) - b / (3 * a);

                    x.Add(x1);
                }
            }

            if (delta < 0)
            {
                double can_truoc = Math.Pow(k + Math.Sqrt(k * k + 1), 1.0f / 3);
                double can_sau = Math.Pow(k - Math.Sqrt(k * k + 1), 1.0f / 3);

                double x1 = Math.Sqrt(Math.Abs(delta)) / (3 * a) * (can_truoc + can_sau) - b / (3 * a);

                x.Add(x1);
            }

            return x;
        }

        //ve tiep tuyen
        public override void DrawTangentialLine(Point TangentialPoint, OpenGL gl)
        {
            P1 myLine = new P1();
            List<float> arrParameters_P1 = new List<float>();
            float f_ = 3 * (float)arrParameters[0] * TangentialPoint.X * TangentialPoint.X + 2 * (float)arrParameters[1] * TangentialPoint.X + (float)arrParameters[2];//tính đạo hàm
            arrParameters_P1.Add(f_);//tham số a đường thẳng
            arrParameters_P1.Add(f_ * -1 * TangentialPoint.X + TangentialPoint.Y);//b
            myLine.Draw(gl);
        }

        public override PointF TangentialLine(Point TangentialPoint, OpenGL gl)
        {
            PointF tmp = new PointF();
            tmp.X = 3 * (float)arrParameters[0] * TangentialPoint.X * TangentialPoint.X + 2 * (float)arrParameters[1] * TangentialPoint.X + (float)arrParameters[2];//tính đạo hàm
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
            tmp.X = -arrParameters[1] / (3 * arrParameters[0]);
            tmp.Y = arrParameters[0] * tmp.X * tmp.X * tmp.X + arrParameters[1] * tmp.X * tmp.X + arrParameters[2] * tmp.X + arrParameters[3];
            tmp.X = tmp.X * scale + Root.X;
            tmp.Y = tmp.Y * scale + Root.Y;
            specialPoint.Add(tmp);

            addFromP2();
        }

        /// <summary>
        /// Hàm tìm vi trí từ đạo hàm
        /// </summary>
        private void addFromP2()
        {
            float delta = 4 * arrParameters[1] * arrParameters[1] - 12 * arrParameters[0] * arrParameters[2];
            PointF tmp = new PointF();

            if (delta > 0)
            {
                tmp.X = (-2 * arrParameters[1] + (float)Math.Sqrt(delta)) / (6 * arrParameters[0]);
                tmp.Y = arrParameters[0] * tmp.X * tmp.X * tmp.X + arrParameters[1] * tmp.X * tmp.X + arrParameters[2] * tmp.X + arrParameters[3];
                tmp.X = tmp.X * scale + Root.X;
                tmp.Y = tmp.Y * scale + Root.Y;
                specialPoint.Add(tmp);

                tmp.X = (-2 * arrParameters[1] - (float)Math.Sqrt(delta)) / (6 * arrParameters[0]);
                tmp.Y = arrParameters[0] * tmp.X * tmp.X * tmp.X + arrParameters[1] * tmp.X * tmp.X + arrParameters[2] * tmp.X + arrParameters[3];
                tmp.X = tmp.X * scale + Root.X;
                tmp.Y = tmp.Y * scale + Root.Y;
                specialPoint.Add(tmp);
            }
        }
    }
}