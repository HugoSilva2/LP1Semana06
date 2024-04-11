using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            //colors
            Color color1 = new Color(255, 50, 70);
            Color color2 = new Color(255, 255, 255);
            Color color3 = new Color(77, 84, 25, 55);

            //Spheres
            Sphere hampter = new Sphere(color1, 20);
            Sphere jeff = new Sphere(color2, 40);
            Sphere cube = new Sphere(color3, 10);

            
        }
    }
}
