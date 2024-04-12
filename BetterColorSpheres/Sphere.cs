using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        //Variables
        
        readonly private Color color;
        public double Radius {get; private set; }
        public int Throws {get; private set; }

        //Constructor
        public Sphere(Color color, double radius)
        {
            this.color = color;
            this.Radius = radius;
            Throws = 0;
        }

        //Methods
        public void Pop() {this.Radius = 0; }

        public void Throw()
        {
            if (this.Radius > 0) this.Throws++;
            {
                Console.WriteLine("You can't throw a popped ball");
            }
        }

        public int GetTimesThrown()
        {
            return Throws;
        }

        public void Status()
        {
            byte r = color.Red;
            byte g = color.Green;
            byte b = color.Blue;
            byte a = color.Alpha;


            Console.WriteLine($"Color: ({r},{g},{b},{a}).");
            Console.WriteLine($"Radius: {Radius}.");
            Console.WriteLine($"Times Thrown {Throws}.");
        }
    }
}