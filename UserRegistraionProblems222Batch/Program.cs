﻿using System;

namespace UserRegistraionProblems222Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems using Regex");
            
            Console.WriteLine("\nChoose UC to execute\n1:Validate first name\n2:Validate last name\n3:Validate Email");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ValidateFirstName.Validate();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}