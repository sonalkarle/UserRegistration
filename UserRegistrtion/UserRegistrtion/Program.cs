using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
       //Validate Password Rule1
        Regex passwordregex = new Regex(@"^[A-Za-z]{8}$");
        
        public void passwordValidation(string password)
        {
            Console.WriteLine("password " + password);
            if (passwordregex.IsMatch(password))
                Console.WriteLine("Valid password ");
            else
                Console.WriteLine("password is not valid");
        }

        public static void Main(string[] args)
        {
            Program person = new Program();
            Console.WriteLine("Enter password as per Rule1");
            string password = Console.ReadLine();
            person.passwordValidation(password);
        }


    }
}