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
            RetrieveTop2Records_ForAgeLessThan60(personDetails);
            RetrieveRecords_ForAgeBetween13To18(personDetails);
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

        // UC 2
        private static void RetrieveTop2Records_ForAgeLessThan60(List<Person> personDetails)
        {
            Console.WriteLine("Top 2 persons having age less than 60 : ");
            foreach (Person person in personDetails.FindAll(p => p.Age < 60).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t Age : " + person.Age);
            }
        }

        // UC 3
        private static void RetrieveRecords_ForAgeBetween13To18(List<Person> personDetails)
        {
            Console.WriteLine("\nPersons having age between 13 to 18 : ");
            foreach (Person person in personDetails.FindAll(p => p.Age > 13 && p.Age < 18).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t Age : " + person.Age);
            }
        }
    }
}
