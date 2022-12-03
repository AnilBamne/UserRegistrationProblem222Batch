using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistraionProblems222Batch
{
    public class ValidateLastName
    {
        public static void Validate()
        {
            Console.WriteLine("Enter Last Name");
            string fName = Console.ReadLine();
            string regex = "^[A-Z]{1}[a-zA-z]{2,}$";           //regex pattern
            bool result = Regex.IsMatch(fName, regex);
            Console.WriteLine(result);
        }
    }
}
