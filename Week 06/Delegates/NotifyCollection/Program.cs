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
        public static void Main()
        {
            NotifyCollection<Person> col = new NotifyCollection<Person>();
            var person1 = new Person(1);
            var person2 = new Person(2);
            var person3 = new Person(3);
            List<Person> people = new List<Person> { person1, person2, person3 };

            col.Items = people;
            col.CollectionChanged += (o, e) => { Console.WriteLine(e.PropertyName); };
            col.AddNumber(person1);
            person1.Age = 10;
            col.Remove(person1);
            person1.Age = 5;
        }

        /// <summary>
        /// Test class person.
        /// </summary>
        private class Person : INotifyPropertyChanged
        {
            /// <summary>
            /// Person Age.
            /// </summary>
            private int age;

            /// <summary>
            /// Initializes a new instance of the <see cref="Person"/> class.
            /// </summary>
            /// <param name="age">Sets person age.</param>
            public Person(int age)
            {
                this.age = age;
            }

            /// <summary>
            /// Property changed event handler.
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Gets or sets person age.
            /// </summary>
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
