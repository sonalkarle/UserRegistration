using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
        //Validate with predefiend format mobile number
        Regex mobileNumberregex = new Regex(@"^[1-9]{2}[][1-9]1{0}$");
       
        public void mobileNumberValidation(string mobileNumber)
        {
            Console.WriteLine("mobile number" + mobileNumber);
            if (mobileNumberregex.IsMatch(mobileNumber))
                Console.WriteLine("Valid number ");
            else
                Console.WriteLine("number id is not valid");
        }

        public static void Main(string[] args)
        {
            Program person = new Program();
            Console.WriteLine("Enter mobile number:");
            string mobileNumber = Console.ReadLine();

            person.mobileNumberValidation(mobileNumber);
        }


    }
}