using System;
namespace Student
{
    class Student
    {
        public string name;
        public int id;
        public Student(string Name , int Id)
        {
            name = Name;
            id = Id;
        }

        public string getName()
        {
           Console.Write("Enter Student Name : ");
           string name = Console.ReadLine();
           return name;
        }

         public int getId()
        {
            Console.Write("Enter Student ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
       
        static void Main(string[] args)
        {
            Student s = new Student("mg mg" , 34);
            Console.WriteLine("Name = " + s.getName());
            Console.WriteLine("Id = " + s.getId());
        }
    }
}