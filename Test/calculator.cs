using System;

namespace Test
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            double currentResult;

            
            while (true)
            {
                Console.Write("Enter the initial number: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out currentResult))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter a correct number.");
                }
            }

            
            while (true)
            {
                Console.WriteLine("\nCurrent Result: " + currentResult);
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Power (square)");
                Console.WriteLine("6. Exit");
                Console.Write("Your choice: ");

                string choiceInput = Console.ReadLine();
                if (!int.TryParse(choiceInput, out int choice))
                {
                    Console.WriteLine(" Invalid choice. Please enter a number.");
                    continue;
                }

                if (choice == 6)
                {
                    Console.WriteLine(" Goodbye");
                    break;
                }

                Console.Write("Enter next number: ");
                string nextInput = Console.ReadLine();
                if (!double.TryParse(nextInput, out double y))
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        currentResult = Operations.Add(currentResult, y);
                        break;
                    case 2:
                        currentResult = Operations.Subtract(currentResult, y);
                        break;
                    case 3:
                        currentResult = Operations.Multiply(currentResult, y);
                        break;
                    case 4:
                        currentResult = Operations.Divide(currentResult, y);
                        break;
                    case 5:
                        currentResult = Operations.Power(currentResult);
                        break;
                    default:
                        Console.WriteLine(" Unknown operation.");
                        break;
                }
            }
        }
    }

   
    class Operations
    {
        public static double Add(double currentResult, double y) => currentResult + y;
        public static double Subtract(double currentResult, double y) => currentResult - y;
        public static double Multiply(double currentResult, double y) => currentResult * y;
        public static double Divide(double currentResult, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("⚠️ Cannot divide by zero.");
                return currentResult;
            }
            return currentResult / y;
        }
        public static double Power(double currentResult) => currentResult * currentResult;
    }
}
