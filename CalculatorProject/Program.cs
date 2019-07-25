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
            Console.WriteLine($"Enter the Key relating to the Operation you want to perform:{Environment.NewLine}" +
                $"[A]dd, S[ubtract], [M]ultiply, [D]ivide");
            Operation instance = new Operation(Console.ReadLine(), firstValue, secondValue);
        }
    }
    class Operation {
        public string operationKey { get; set; }
        public decimal firstDecimal { get; set; }
        public decimal secondDecimal { get; set; }

        public Operation (string operation, decimal value1, decimal value2) {
            this.operationKey = operation;
            this.firstDecimal = value1;
            this.secondDecimal = value2;
        }

        public decimal action (decimal value1, decimal value2, string operation) {
            value1 = this.firstDecimal;
            value2 = this.secondDecimal;
            operation = this.operationKey;
            string operationUpper = operation.ToUpper();
            char operationChar = operationUpper[0];
            decimal final = 0m;

            switch (operationChar) {
                case 'A':
                    final = value1 + value2;
                    break;
                case 'S':
                    final = value1 - value2;
                    break;
                case 'M':
                    final = value1 * value2;
                    break;
                case 'D':
                    final = value1 / value2;
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            return final;
        }
    }
}
