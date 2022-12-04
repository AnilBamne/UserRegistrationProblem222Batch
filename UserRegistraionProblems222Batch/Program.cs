using System;

namespace UserRegistraionProblems222Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems using Regex");
            runAgain:
            Console.WriteLine("\nChoose UC to execute\n1:Validate first name\n2:Validate last name\n3:Validate Email\n4:Validate Mobile Number\n5:Password rule1\n6:Password rule2\n7:Password rule3\n" +
                "8:Password rule4\n9:Email samples\n");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ValidateFirstName.Validate();
                    break;
                case 2:
                    ValidateLastName.Validate();
                    break;
                case 3:
                    ValidateEmail.Validate();
                    break;
                case 4:
                    ValidateMobileNumber.Validate();
                    break;
                case 5:
                    ValidatePassword.Rule1();
                    break;
                case 6:
                    ValidatePassword.Rule2();
                    break;
                case 7:
                    ValidatePassword.Rule3();
                    break;
                case 8:
                    ValidatePassword.Rule4();
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
            goto runAgain;
        }
    }
}
