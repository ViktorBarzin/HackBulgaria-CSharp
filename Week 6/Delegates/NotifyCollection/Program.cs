namespace NotifyCollection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Main method.
        /// </summary>
        static void Main()
        {
            // Check person propert changes

            NotifyCollection<Person> col = new NotifyCollection<Person>();
            var person1 = new Person(1);
            var person2 = new Person(2);
            var person3 = new Person(3);
            List<Person> people = new List<Person> { person1, person2, person3 };

            col.Items = people;
            col.CollectionChanged += CollectionChanged;
            col.Remove(person1);
            person1.Age = 10;

            //Console.WriteLine(string.Join(",", col.Items));
        }

        /// <summary>
        /// Action when collection changes.
        /// </summary>
        /// <param name="sender">Sender who invoked the event.</param>
        /// <param name="e">Event arguments.</param>
        private static void CollectionChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("{0}", e.PropertyName);
        }

        /// <summary>
        /// Test class person.
        /// </summary>
        private class Person : INotifyPropertyChanged
        {
            private int age;
            public event PropertyChangedEventHandler PropertyChanged;

            public Person(int age)
            {
                this.age = age;
            }

            public int Age
            {
                get
                {
                    return this.age;
                }
                set
                {
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Age changed"));
                    }

                    this.age = value;
                }
            }
        }
    }
}
