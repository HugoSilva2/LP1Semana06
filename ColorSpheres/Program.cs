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

            //ACTIONS

            
            //show no mercy to hampter

            for(int i = 0; i < 15; i++)
            {
                hampter.Throw();
            }

            //check how many times hampter was thrown

            Console.WriteLine(hampter.GetTimesThrown());
            
            
            //pop cube
            cube.Pop();

            //Check if cube can't be thrown while popped
            cube.Throw();

            //throw first
            jeff.Throw();

            //pop after
            jeff.Pop();

            //Status Check
            hampter.Status();
            jeff.Status();
            cube.Status();

        }
    }
}
