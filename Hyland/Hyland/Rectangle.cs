using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyland
{
    class Rectangle
    {

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value;  }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { width = value; }
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return height * width;
        }
        public int GetPerimeter()
        {
            return (height + width) * 2;
        }
    }
}
