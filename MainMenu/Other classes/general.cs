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
    class Graph
    {
        Point Root;
        int scale;
        Color NetColor;
        Color AxisColor;
        Color NumColor;

        public Graph(Point Root, int scale)
        {
            this.Root = Root;
            this.scale = scale;
        }

        public void updateNumColor(Color NumColor)
        {
            this.NumColor = NumColor;
        }

        public void update(Color NetColor, Color AxisColor)
        {
            this.AxisColor = AxisColor;
            this.NetColor = NetColor;
        }

        public void updateAxis(Point Root, int scale)
        {
            this.Root = Root;
            this.scale = scale;
        }

        // Vẽ lưới tọa độ cùng với trục chính
        public void Build(OpenGL gl, bool displayNet)
        {
            // Vẽ lưới
            //if (scale > 20)
            if (displayNet)
                DrawNet(gl);

            // Vẽ 2 trục chính
            DrawMainAxis(gl);

            // Vẽ trục số Ox
            Draw_X_Axis(gl, displayNet);

            // Vẽ trục số Oy
            Draw_Y_Axis(gl, displayNet);

            // Hiện gốc tọa đô O(0, 0);
            gl.DrawText(Root.X - 15, Root.Y - 15, NumColor.R / 255.0f, NumColor.G / 255.0f, NumColor.B / 255.0f, "Times New Roman" + " Bold", 16, "O");
            gl.PointSize(6);
            gl.Begin(OpenGL.GL_POINTS);

            gl.Vertex(Root.X, Root.Y);
            gl.End();
            gl.Flush();
        }

        // Vẽ trục chính
        private void DrawMainAxis(OpenGL gl)
        {
            gl.Color(AxisColor.R / 255.0, AxisColor.G / 255.0, AxisColor.B / 255.0, AxisColor.A / 255.0);
            gl.LineWidth(3);

            gl.Begin(OpenGL.GL_LINES);
            // Đường nằm ngang
            gl.Vertex(0, Root.Y);
            gl.Vertex(gl.RenderContextProvider.Width, Root.Y);
            gl.End();

            // Đường dọc
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(Root.X, 0);
            gl.Vertex(Root.X, gl.RenderContextProvider.Height);
            gl.End();

            gl.Flush();
        }

        // Vẽ lưới tọa độ
        private void DrawNet(OpenGL gl)
        {
            int spacing = 1;// giãn cách giữa 2 vị trí tọa độ thực được hiển thị
            int maxX = (-Root.X + gl.RenderContextProvider.Width) / scale + 1;
            int maxY = (-Root.Y + gl.RenderContextProvider.Height) / scale + 1;

            if (scale < 30)
            {
                spacing = 50 / scale;
            }

            gl.LineWidth(1);
            gl.Color(NetColor.R / 255.0, NetColor.G / 255.0, NetColor.B / 255.0, NetColor.A / 255.0);

            // Vẽ các đường dọc
            int minX = -Root.X / scale - 1;
            while (minX % spacing != 0)
            {
                minX++;
            }
            gl.Begin(OpenGL.GL_LINES);
            for (int x = minX; x < maxX; x += spacing)
            {
                gl.Vertex(x * scale + Root.X, 0);
                gl.Vertex(x * scale + Root.X, gl.RenderContextProvider.Height);
            }
            gl.End();
            // Vẽ các đường ngang
            int minY = -Root.Y / scale - 1;
            while (minY % spacing != 0)
            {
                minY++;
            }
            gl.Begin(OpenGL.GL_LINES);
            for (int y = minY; y < maxY; y += spacing)
            {
                gl.Vertex(0, Root.Y + y * scale);
                gl.Vertex(gl.RenderContextProvider.Width, Root.Y + y * scale);
            }
            gl.End();
        }

        // Vẽ trục số Ox
        private void Draw_X_Axis(OpenGL gl, bool displayNet)
        {
            int spacing = 1;// giãn cách giữa 2 vị trí tọa độ thực được hiển thị
            if (scale < 30)
            {
                spacing = 50 / scale;
            }
            int maxX = (-Root.X + gl.RenderContextProvider.Width) / scale + 1;
            int minX = -Root.X / scale - 1;

            while (minX % spacing != 0)
            {
                minX++;
            }
            for (int x = minX; x < maxX; x += spacing)
            {
                if (x != 0)
                {
                    gl.DrawText(x * scale + Root.X + 2, Root.Y - 15, NumColor.R / 255.0f, NumColor.G / 255.0f, NumColor.B / 255.0f, "Times News Roman", 13, x.ToString());

                    // Các vạch đánh dấu đơn vị trên trục Ox
                    if (!displayNet)
                        gl.DrawText(x * scale + Root.X - 1, Root.Y - 2, NumColor.R / 255.0f, NumColor.G / 255.0f, NumColor.B / 255.0f, "", 7, "|");
                }
            }
        }

        // Vẽ trục số Oy
        private void Draw_Y_Axis(OpenGL gl, bool displayNet)
        {
            int spacing = 1;
            if (scale < 30)
            {
                spacing = 50 / scale;
            }

            int maxY = (-Root.Y + gl.RenderContextProvider.Height) / scale + 1;
            int minY = -Root.Y / scale - 1;
            while (minY % spacing != 0)
            {
                minY++;
            }

            for (int y = minY; y < maxY; y += spacing)
            {
                if (y != 0)
                {
                    gl.DrawText(Root.X + 5, y * scale + Root.Y - 15, NumColor.R / 255.0f, NumColor.G / 255.0f, NumColor.B / 255.0f, "Times News Roman", 13, y.ToString());

                    // Các vạch đánh dấu đơn vị trên trục Oy
                    if (!displayNet)
                        gl.DrawText(Root.X - 4, y * scale + Root.Y + 2, NumColor.R / 255.0f, NumColor.G / 255.0f, NumColor.B / 255.0f, "", 14, "_");
                }
            }
        }
    }
}