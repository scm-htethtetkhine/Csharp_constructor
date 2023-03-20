using System;
namespace Rectangle
{
    class Rectangle
    {
        public int width;
        public int height;
        public Rectangle(int Width , int Height)
        {
            width = Width;
            height = Height;
        }

        public int getArea()
        {
           Console.Write("Enter Width : ");
           int width = Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter Height : ");
           int height = Convert.ToInt32(Console.ReadLine());
           return ( width * height ) ;
        }
        public int getPerimeter()
        {
           Console.Write("Enter Width : ");
           int width = Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter Height : ");
           int height = Convert.ToInt32(Console.ReadLine());
          return (2 * width) + ( 2 * height) ;
        }
   
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2 , 5);
            Console.WriteLine("Rectangle Area = " + r.getArea());
            Console.WriteLine("Rectangle Perimeter = " + r.getPerimeter());
        }
    }
}