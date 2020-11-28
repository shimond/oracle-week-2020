using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace CharpNews
{
    static class Version6
    {

        public static void Print(Person p)
        {
            if(p == null)
            {
                //throw new ArgumentNullException("p");

                //The nameof expression
                throw new ArgumentNullException(nameof(p));

            }
        }

        // Null-conditional operators
        static bool IsMatch(Person p, string country)
        {
            return p?.Address?.Country == country;
        }

        public class Person
        {
            // auto init
            public string Name { get; } = "DEFAULT_NAME";

            private int _property;

            //properties as expression
            public int MyProperty { get => this._property; set => this._property = value; }

            public Address Address { get; set; }

            //functions as expression ”
            public override string ToString() => $"Person name = {this.Name}"; // String interpolation


            public void DoIt()
            {
                //is read only
                //Name = "123";
            }
        }
       public  class Address
        {
            public string Country { get; set; }
        }
    }

    static class Printer
    {

        public static void DoIt()
        {
            try
            {
                WriteLine("Enter your name");
                string name = ReadLine();
                WriteLine($"Your name is {name}");
            
            }                   //Exception filter with where keyword
            catch (Exception ex) when (ex.Message.Length == 9)
            {
                throw;
            }
        }
    }
}
