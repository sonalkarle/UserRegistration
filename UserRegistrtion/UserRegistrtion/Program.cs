using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
        //Validate password with valid input as per rule3
        Regex passwordregex = new Regex(@"^[A-Z][A-Za-z1-0]{6}[0-1]$");
        
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
            Console.WriteLine("Enter the password as per the rule 3 ");
            string password = Console.ReadLine();
            person.passwordValidation(password);
        }


    }
}