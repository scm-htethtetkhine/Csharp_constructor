using System;
namespace Circle
{
    class Circle
    {
        public double pi;
        public int radius;
        public Circle(double Pi , int Radius)
        {
            pi = Pi;
            radius = Radius;
        }

        public double getCirclearea()
        {
           Console.Write("Enter radius : ");
           int radius = Convert.ToInt32(Console.ReadLine());
           return ( pi * radius * radius ) ;
        }
        public double getCircumference()
        {
           Console.Write("Enter radius : ");
           int radius = Convert.ToInt32(Console.ReadLine());
          return (2 * pi * radius) ;
        }
   
        static void Main(string[] args)
        {
            Circle c = new Circle(3.14 , 3);
            Console.WriteLine("Circle Area = " + c.getCirclearea());
            Console.WriteLine("Circle circumference = " + c.getCircumference());
        }
    }
}