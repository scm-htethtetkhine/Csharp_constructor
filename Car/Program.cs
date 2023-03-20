using System;
namespace Car
{
    class Car
    {
        public string model;
        public int year;
        public Car(string Model , int Year)
        {
            model = Model;
            year = Year;
        }

        public string getModel()
        {
           Console.Write("Enter Car Name : ");
           string model = Console.ReadLine();
           return model;
        }

         public int getYear()
        {
            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            return year;
        }
       
        static void Main(string[] args)
        {
            Car c = new Car("Volvo" , 2013);
            Console.WriteLine("Car Model = " + c.getModel());
            Console.WriteLine("Car Year = " + c.getYear());
        }
    }
}