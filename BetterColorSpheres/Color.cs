using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {        
        //colors
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }
        public byte Alpha { get;}

        public byte Grey
        { 
            get
            {
                byte grey = (byte) ((Red + Green + Blue) / 3);
                return grey;
            }

        }

        //construtor
        public Color(byte r, byte g , byte b, byte a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }

        //overload
        public Color(byte r, byte g, byte b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
        }   

    }
}