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
        public static void EmailSamples()
        {
            string[] emailSamples = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                "abc@1.com","abc@gmail.com.com","abc+100@gmail.com",
                                "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com",
                                "abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            foreach (string email in emailSamples)
            {
                if (Regex.IsMatch(email, regexCondition))
                {
                    Console.WriteLine("{0}      => Valid", email);
                }
                else
                {
                    Console.WriteLine("{0}      =>Invalid", email);
                }
            }
        }
    }
}
