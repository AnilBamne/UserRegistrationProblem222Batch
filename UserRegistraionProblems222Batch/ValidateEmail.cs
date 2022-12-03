using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistraionProblems222Batch
{
    public class ValidateEmail
    {
        public static void Validate()                       //ststic method for validating Email
        {
            Console.WriteLine("Enter Email ID \n E.g. : abc.xyz@bl.co.in");
            string email = Console.ReadLine();
            string regex = "^[a-z]{3}[.][a-z]{3}[@][a-z]{2}[.][a-z]{2}[.][a-z]{2}$";        //regex pattern
            bool result = Regex.IsMatch(email, regex);
            Console.WriteLine(result);
        }
    }
}
