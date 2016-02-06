namespace INotifyPropertyChanged
{
    using System;

    /// <summary>
    /// Application class
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            var person = new Person();
            person.PropertyChanged += PersonPropertyChanged;
            person.Age = 12;
            person.Name = "goshfsksodfksodfhsudfo";
            person.Age = 1;
        }

        /// <summary>
        /// Person property changed delegate.
        /// </summary>
        /// <param name="sender">Event invoker.</param>
        /// <param name="e">Event arguments.</param>
        private static void PersonPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine(sender.GetHashCode());
            Console.WriteLine("{0} property changed", e.PropertyName);
        }
    }
}
