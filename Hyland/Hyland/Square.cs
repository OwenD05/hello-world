using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyland
{

    class Square
    {

        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Square(int size)
        {
            this.size = size;
        }

        public int GetArea()
        {
            return size * size;
        }

        public int GetPerimeter()
        {
            return size * 4;
        }
    }
}
