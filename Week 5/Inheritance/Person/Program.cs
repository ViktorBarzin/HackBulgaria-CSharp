namespace Person
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>() { new Person("male"), new Adult("female"), new Child("male") };

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
