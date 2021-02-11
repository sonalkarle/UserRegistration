using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
        //Validate the last name with first letter should be capital and minimum 3 character
        Regex lastnameregex = new Regex(@"^[A-Z][A-Za-z]{2,}$");

        public void FirstNameValidation(string lastName)
        {
            Console.WriteLine("last name" + lastName);
            if (lastnameregex.IsMatch(lastName))
                Console.WriteLine("Valid last name");
            else
                Console.WriteLine("first name is not valid");
        }
        static void Main(string[] args)
        {

            Program person = new Program();
            Console.WriteLine("Enter last name: ");
            string lastname = Console.ReadLine();
           
            person.FirstNameValidation(lastname);
        }


    }
}