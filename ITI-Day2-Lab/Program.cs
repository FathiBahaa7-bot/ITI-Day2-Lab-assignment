namespace ITI_Day2_Lab
{
    class Program
    {
        // =========================
        // Exercise 1 - Calculator
        // =========================

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


        static void Main()
        {
            // =========================
            // Exercise 1 - Calculator
            // =========================

            Console.WriteLine("===== Exercise 1 - Calculator =====");

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1- Add");
            Console.WriteLine("2- Subtract");
            Console.WriteLine("3- Multiply");
            Console.WriteLine("4- Divide");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;

                case 2:
                    result = Subtract(num1, num2);
                    break;

                case 3:
                    result = Multiply(num1, num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        break;
                    }

                    result = Divide(num1, num2);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice >= 1 && choice <= 4 && !(choice == 4 && num2 == 0))
            {
                Console.WriteLine("Result = " + result);
            }


            // =========================
            // Exercise 2 - String
            // =========================

            Console.WriteLine("\n===== Exercise 2 - String =====");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Original Name: " + name);
            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Length: " + name.Length);
            Console.WriteLine("Trimmed Name: " + name.Trim());


            // =========================
            // Exercise 3 - Gmail
            // =========================

            Console.WriteLine("\n===== Exercise 3 - Gmail Validation =====");

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            if (email.EndsWith("@gmail.com"))
            {
                Console.WriteLine("Valid Gmail");
            }
            else
            {
                Console.WriteLine("Invalid Gmail");
            }


            // =========================
            // Exercise 4 - Names Array
            // =========================

            Console.WriteLine("\n===== Exercise 4 - Names =====");

            string[] names = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNames in Uppercase:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i].ToUpper());
            }


            // =========================
            // Exercise 5 - Array Basics
            // =========================

            Console.WriteLine("\n===== Exercise 5 - Even or Odd =====");

            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNumbers and Parity:");

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i] + " - Even");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " - Odd");
                }
            }


            // =========================
            // Exercise 6 - Array Calculations
            // =========================

            Console.WriteLine("\n===== Exercise 6 - Array Calculations =====");

            int sum = 0;
            int largest = numbers[0];
            int minimum = numbers[0];

            for (int i = 0; i < 5; i++)
            {
                sum = sum + numbers[i];

                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }

                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Largest Number = " + largest);
            Console.WriteLine("Minimum Number = " + minimum);


            // =========================
            // End
            // =========================

            Console.WriteLine("\n===== All Exercises Completed =====");
        }
    }
}
