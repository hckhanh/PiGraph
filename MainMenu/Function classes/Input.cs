using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SharpGL;

namespace PixelsGraph
{
    abstract class Input
    {
        protected List<PointF> arrPoints;
        protected List<float> arrParameters;
        protected Color clr;
        protected int type;
        protected List<PointF> specialPoint = new List<PointF>();

        public static Point Root;
        public static int scale = 50;
        public static float DepthLine = 1.5f;

        public Input()
        {
            arrPoints = new List<PointF>();
            List<float> arrParameters = new List<float>();
            type = 0;
        }

        //cap nhat cac thong so cua ham
        public void update(List<float> arrParameters, int scale, Color clr)
        {
            this.arrParameters = arrParameters;
            Input.scale = scale;
            this.clr = clr;
        }

        /// <summary>
        /// Tuy chinh ham tri tuyet.
        /// type:
        /// t = 0: f(x)
        /// t = 1: |f(x)|
        /// t = 2: f(|x|)
        /// </summary>
        /// <param name="t">The type of function.</param>
        public void setType(int t)
        {
            type = t;
        }

        //ve ham so va nhung duong, diem lien quan
        public void Draw(OpenGL gl)
        {
            switch (type)
            {
                case 0:
                    DrawFunc(ref gl);
                    drawSpecialPoint(ref gl);
                    break;
                case 1:
                    DrawFuncAbs(ref gl);
                    break;
                case 2:
                    DrawFuncXAbs(ref gl);
                    break;
            }

            DrawShape(ref gl);
        }

        //ve ham tri tuyet
        public virtual void DrawFuncAbs(ref OpenGL gl) { }

        //ve ham
        public virtual void DrawFunc(ref OpenGL gl) { }

        //ve ham tri tuyet bien X
        public virtual void DrawFuncXAbs(ref OpenGL gl) { }

        //ve duong, diem lien quan
        public virtual void DrawShape(ref OpenGL gl) { }

        //tim nhung diem dac biet
        public virtual void FindSpecialPoint(ref OpenGL gl) { }

        //ve tiep tuyen
        public virtual void DrawTangentialLine(Point TangentialPoint, OpenGL gl) { }

        //lay thong tin cac thong so
        public virtual void get(List<float> arrPara, Color clr) { }

        /// <summary>
        /// Hàm tìm hệ số góc của đường tiếp tuyến
        /// </summary>
        /// <param name="TangentialPoint">Điểm cần vẽ tiếp tuyến</param>
        /// <param name="gl"></param>
        /// <returns></returns>
        public virtual PointF TangentialLine(Point TangentialPoint, OpenGL gl)
        {
            return new PointF();
        }

        /// <summary>
        /// Tìm các điểm đặc biệt
        /// </summary>
        /// <param name="des">danh sách điểm đặc biệt được thêm vào</param>
        protected virtual void addSpecialPoint()
        {
        }

        protected void drawSpecialPoint(ref OpenGL gl)
        {
            addSpecialPoint();

            gl.PointSize(5F);
            gl.Color(1.0 - clr.R / 255.0, clr.G / 255.0, clr.B / 255.0, clr.A / 255.0);

            gl.Begin(OpenGL.GL_POINTS);
            for (int i = 0; i < specialPoint.Count; i++)
                gl.Vertex(specialPoint[i].X, specialPoint[i].Y);
            gl.End();
        }
    }
}
