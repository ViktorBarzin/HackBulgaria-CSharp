namespace AppointmentsIntersection
{
    using System;

    /// <summary>
    /// You are given a list of appointments and your task is to find the intersecting appointments.
    /// Write a method which takes two equal-sized arrays as arguments and prints one line for each pair
    /// of intersecting appointments.The line should be in the format:
    /// The appointment starting at<![CDATA[ dd/mm/yyyy hh:mm]]> intersects the appointment starting at
    /// <![CDATA[dd/mm/yyyy hh:mm]]> with exactly <![CDATA[mmmm]]> minutes.
    /// void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Read the class documentation.
        /// </summary>
        /// <param name="startDates">Array of Start dates.</param>
        /// <param name="durations">Array of durations.</param>
        public static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            for (int i = 0; i < startDates.Length - 1; i++)
            {
                if (startDates[i] + durations[i] > startDates[i + 1])
                {
                    Console.WriteLine("The appointment starting at {0}\nintersepts with the meeting starting at {1}", startDates[i].ToString("dd/MM/yyyy HH:mm"), startDates[i + 1].ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            DateTime[] startDates = { new DateTime(2015, 12, 12, 13, 13, 13), new DateTime(2015, 12, 12, 14, 14, 14), new DateTime(2015, 12, 12, 15, 15, 15) };

            TimeSpan[] durations = { new TimeSpan(1, 40, 1), new TimeSpan(1, 0, 1), new TimeSpan(0, 0, 10) };

            FindIntersectingAppointments(startDates, durations);
        }
    }
}