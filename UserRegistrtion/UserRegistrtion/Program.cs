using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
       //Validate result with passsword rule 04
        Regex passwordregex = new Regex(@"^[A-Z][A-Za-z1-9]{5}[@,-,$,*][0-1]$");
      
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
            string password = Console.ReadLine();
            person.passwordValidation(password);
        }


    }
}