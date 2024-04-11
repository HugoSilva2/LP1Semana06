using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {        
        //colors
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        //getters
        public byte GetRed() { return red; }
        public byte GetGreen() { return green; }
        public byte GetBlue() { return blue; }
        public byte GetAlpha() { return alpha;}

        //constructors
        public Color(byte r, byte g , byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        public Color(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
            alpha = 255;
        }   

        //GetGrey Method
        public byte GetGrey()
        { 
            byte grey = (byte) ((red + green + blue) / 3);

            return grey;
        }

    }
}