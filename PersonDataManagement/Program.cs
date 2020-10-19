using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management Problem !");
            List<Person> personDetails = new List<Person>();
            AddRecords(personDetails);
        }

        //UC 1
        private static void AddRecords(List<Person> personDetails)
        {
            personDetails.Add(new Person("254589652", "John", "Mumbai", 15));
            personDetails.Add(new Person("254589652", "Sam", "Nagpur", 50));
            personDetails.Add(new Person("254589652", "Joey", "Kerela", 17));
            personDetails.Add(new Person("254589652", "Alan", "Delhi", 44));
            personDetails.Add(new Person("254589652", "Jim", "Jaipur", 20));
            personDetails.Add(new Person("254589652", "Sim", "Mumbai", 80));
        }
    }
}
