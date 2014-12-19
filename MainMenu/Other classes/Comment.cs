using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PixelsGraph
{
    class Comment
    {
        public string str;
        public Color clr;

        public Comment()
        {
            clr = Color.Black;
            str = string.Empty;
        }

        public Comment(string str, Color clr)
        {
            this.clr = clr;
            this.str = str;
        }

        public void set(string str, Color clr)
        {
            this.str = str;
            this.clr = clr;
        }
    }
}
