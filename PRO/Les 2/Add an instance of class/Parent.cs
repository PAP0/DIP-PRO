using System;
namespace classAssignment
{
    public class Parent:Person
    {
        private int age;
		public Parent(string name, int age) : base(name)
        {
            this.age = age;
            Console.WriteLine("you are " + age);
        }
    }
}