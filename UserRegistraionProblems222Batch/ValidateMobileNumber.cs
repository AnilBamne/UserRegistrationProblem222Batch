using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistraionProblems222Batch
{
    public class ValidateMobileNumber
    {
        public static void Validate()
        {
            Console.WriteLine("Enter Mobile number");
            string fName = Console.ReadLine();
            string regex = "^^[9]{1}[1]{1}[\\s][6-9]{1}[0-9]{9}$";           //regex pattern
            bool result = Regex.IsMatch(fName, regex);
            Console.WriteLine(result);
        }
    }
}
