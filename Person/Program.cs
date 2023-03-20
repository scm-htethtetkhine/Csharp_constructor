using System;

namespace Person
{
     class Person
     {
        public string name;
        public int age;
        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        // Copy Constructor
        public Person(Person person)
        {
            name = person.name;
            age = person.age;
        }
         public string getName()
        {
           Console.Write("Enter Person Name : ");
           string name = Console.ReadLine();
           return name;
        }

         public int getAge()
        {
            Console.Write("Enter Person Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
     }
     class Program
     {
        static void Main(string[] args)
        {
            Person person= new Person("", 23);
            Person person1 = new Person(person);
             Console.WriteLine("Name = " + person.getName());
            Console.WriteLine("Age = " + person.getAge());
            Console.WriteLine("Name = " + person1.getName());
            Console.WriteLine("Age = " + person1.getAge());
        }
     }
}