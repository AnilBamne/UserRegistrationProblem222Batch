using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistraionProblems222Batch
{
    public class ValidatePassword
    {
        public static void Rule1()                       //Rule 1: Password should have minimum 8 charecters
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string regex = "^[a-zA-Z0-9]{8,}$";        //regex pattern
            bool result = Regex.IsMatch(password, regex);
            Console.WriteLine(result);
        }
        public static void Rule2()                       //Rule 2: Password should atleast 1 Upper case
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string regex = "^(?=.*[A-Z]).{8}";        //regex pattern
            bool result = Regex.IsMatch(password, regex);
            Console.WriteLine(result);
        }
        public static void Rule3()                       //Rule 2: Password should atleast 1 Numeric number
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string regex = "^(?=.*[0-9]).{8}";        //regex pattern
            bool result = Regex.IsMatch(password, regex);
            Console.WriteLine(result);
        }
    }
}
