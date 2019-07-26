using System;

namespace CalculatorProject {
    class Program {
        static void Main(string[] args) {
            decimal firstValue = 0m;
            decimal secondValue = 0m;
            Console.WriteLine("Insert a number and press enter to begin calculator...");
            firstValue = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your first value was {firstValue} {Environment.NewLine}" +
                $"Please enter a second value then press enter to continue...");
            secondValue = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Enter the Key relating to the Operation you want to perform:{Environment.NewLine}" +
                $"[A]dd, [S]ubtract, [M]ultiply, [D]ivide{Environment.NewLine}Press enter to run operation");
            string operatorTest = Convert.ToString(Console.ReadKey());
            Console.Clear();
            decimal result = Operation.action(firstValue, secondValue, operatorTest);
            Console.WriteLine($"The result of your operation is {result}");
        }
    }
    class Operation {
        public string operationKey { get; set; }
        public decimal firstDecimal { get; set; }
        public decimal secondDecimal { get; set; }

        public Operation() {
        }

        public static decimal action(decimal value1, decimal value2, string operation) {
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
