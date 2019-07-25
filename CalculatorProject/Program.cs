using System;

namespace CalculatorProject {
    class Program {
        static void Main(string[] args) {
            decimal firstValue = 0m;
            decimal secondValue = 0m;
            char operation;
            Console.WriteLine("Insert a number and press enter to begin calculator..."); 
            firstValue = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your first value was {firstValue} {Environment.NewLine}" +
                $"Please enter a second value then press enter to continue...");
            secondValue = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your two values are {firstValue} and {secondValue}{Environment.NewLine}Press enter to continue...");
            Console.Read();
            Console.Clear();
            Console.WriteLine($"Enter the Key relation to the Operation you want to perform:{Environment.NewLine}" +
                $"[A]dd, S[ubtract], [M]ultiply, [D]ivide");

        }
    }
    class Operation {
        public char operationKey { get; set; }
        public decimal numberOne { get; set; }
        public decimal numberTwo { get; set; }

        public decimal beginOperation (char operation, decimal NumberOne, decimal NumberTwo) {
            return 0m;
        }
    }
}
