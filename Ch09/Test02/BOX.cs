using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    interface iArea
    {
        double Area();
    }
    public class BOX : iArea
    {
        public double Width, Height, Length;

        public BOX(double w, double Height, double Length)
        {
            Width = w;
            this.Height = Height;
            this.Length = Length;
        }

        public double Volume()
        {
            return Width * Height * Length;
        }

        public double Area()
        {
            return Width * Length;
        }
    }
}
