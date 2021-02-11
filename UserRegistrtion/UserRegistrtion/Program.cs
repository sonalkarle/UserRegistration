using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    { 
        //Validate the email id with 3 mandatory and 2 optional part
        Regex emailIdregex = new Regex(@"^[A-Za-z]{3}[.]([a-zA-Z]{3})*[bl.co][.in]*");
       
        public void emailIdValidation(string emailId)
        {
            Console.WriteLine("EmailId" + emailId);
            if (emailIdregex.IsMatch(emailId))
                Console.WriteLine("Valid email id ");
            else
                Console.WriteLine("email id is not valid");
        }
        public static void Main(string[] args)
        {
            Program person = new Program();
            Console.WriteLine("Enter Email Id: ");
            string emailId = Console.ReadLine();
            person.emailIdValidation(emailId);
        }


    }
}