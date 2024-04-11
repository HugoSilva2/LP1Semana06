using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {        
        //colors
        private byte red { get;}
        private byte green { get;}
        private byte blue { get; set;}
        private byte alpha { get; set;}

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