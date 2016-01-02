namespace Person
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Application Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            List<Person> people = new List<Person>() { new Person("male"), new Adult("female"), new Child("male") };

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
