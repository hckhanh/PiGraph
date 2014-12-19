using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using SharpGL;

namespace PixelsGraph
{
    class Note
    {
        public List<Comment> cmt;
        public PointF pos;
        public int size;
        public int maxlen;
        public float delta = 0.6f;


        public Note()
        {
            cmt = new List<Comment>();
            pos = new PointF(5.5F, -8);
            size = 14;
            maxlen = 0;
        }

        /// <summary>
        /// Thêm hàm ghi chú
        /// </summary>
        /// <param name="src">Chuỗi ghi chú</param>
        /// <param name="clr">Color</param>
        /// <param name="mX">Chiều dài khung OpenGLControl</param>
        public void add(String src, Color clr, int mX)
        {
            if (src.Length > maxlen)
                maxlen = src.Length;
            Comment nCom = new Comment(src, clr);
            cmt.Add(nCom);
            if (pos.X + maxlen * size * delta > mX)
                pos.X = pos.X - maxlen * size * delta;
            if (pos.Y - (cmt.Count - 1) * size <= 0)
                pos.Y = pos.Y + size;
        }

        public void fix(int mX, int mY)
        {
            if (pos.X + maxlen * size * delta > mX)
                pos.X = mX - maxlen * size * delta;
            if (pos.Y > mY - 17)
                pos.Y = mY - 16;
        }

        public void setSize(int s)
        {
            size = s;
        }

        public void updatePos(PointF p, int mX, int mY)
        {
            pos.X += p.X;
            pos.Y += p.Y;
            if (pos.X < 6)
                pos.X = 6;
            if (pos.X > mX - maxlen * size * delta - 1)
                pos.X = mX - maxlen * size * delta - 1;
            if (pos.Y > mY - size - 1)
                pos.Y = mY - size - 1;
            if (pos.Y < (cmt.Count - 1) * size + 5.5F)
                pos.Y = (cmt.Count - 1) * size + 5.5F;
        }

        public void edit(int index, string src, Color clr)
        {
            if (src.Length > maxlen)
                maxlen = src.Length;

            cmt[index].str = src;
            cmt[index].clr = clr;
        }

        public void remove(int index)
        {
            cmt.RemoveAt(index);
            maxlen = 0;
            for (int i = 0; i < cmt.Count; i++)
                if (maxlen < cmt[i].str.Length)
                    maxlen = cmt[i].str.Length;
        }

        public void clear()
        {
            cmt.Clear();
            maxlen = 0;
        }

        public void draw(ref OpenGL gl)
        {
            if (cmt.Count == 0)
                return;
            drawBorder(ref gl);
            int i = 0, dy = 0;
            for (i = 0; i < cmt.Count; i++)
            {
                gl.DrawText((int)pos.X, (int)pos.Y + dy, cmt[i].clr.R / 255.0F, cmt[i].clr.G / 255.0F, cmt[i].clr.B / 255.0F, "Consolas", size, cmt[i].str);
                dy -= size;
            }
        }

        public void drawBorder(ref OpenGL gl)
        {
            gl.Color(1.0F, 1.0F, 1.0F);
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(pos.X - 5, pos.Y + size);
            gl.Vertex(pos.X + maxlen * size * delta, pos.Y + size);
            gl.Vertex(pos.X + maxlen * size * delta, pos.Y - (cmt.Count - 1) * size - 5);
            gl.Vertex(pos.X - 5, pos.Y - (cmt.Count - 1) * size - 5);
            gl.End();
            gl.Color(1.0F, 0, 0);
            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Vertex(pos.X - 5, pos.Y + size);
            gl.Vertex(pos.X + maxlen * size * delta, pos.Y + size);
            gl.Vertex(pos.X + maxlen * size * delta, pos.Y - (cmt.Count - 1) * size - 5);
            gl.Vertex(pos.X - 5, pos.Y - (cmt.Count - 1) * size - 5);
            gl.End();
        }

        public bool inCom(Point p)
        {
            if (p.X > pos.X - 5 && p.X < pos.X + maxlen * size * delta)
                if (p.Y > pos.Y - (cmt.Count - 1) * size - 5 && p.Y < pos.Y + size)
                    return true;
            return false;
        }

    }
}
