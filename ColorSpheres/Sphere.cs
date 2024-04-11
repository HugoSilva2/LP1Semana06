using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        //Variables
        
        readonly private Color color;
        private double radius;
        private int throws;

        //Constructor
        public Sphere(Color color, double radius)
        {
            this.color = color;
            this.radius = radius;
            throws = 0;
        }

        //Methods
        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius == 0)
            {
                Console.WriteLine("You can't throw a popped ball");
            }
            else
            {
                throws += 1;
            }
        }

        public int GetTimesThrown()
        {
            return throws;
        }

        public void Status()
        {
            byte r = color.GetRed();
            byte g = color.GetGreen();
            byte b = color.GetBlue();
            byte a = color.GetAlpha();

            Console.WriteLine($"Color: ({r},{g},{b},{a}).");
            Console.WriteLine($"Radius: {radius}.");
            Console.WriteLine($"Times Thrown {throws}.");
        }
    }
}