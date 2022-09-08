namespace ImprovedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gör en bool variable och deklarerar true!
            bool keepLooping = true;

            // Do this while the loop is running.
            do
            {
                try // if theres an error in the try block of code then catch method will execute below
                {
                    Console.WriteLine("Type two diffrent numbers to calculate!");
                    double firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("And the second number?");
                    double secondNumber = Convert.ToInt32(Console.ReadLine());
                    double sum = 0;

                    MenuOptions();

                    switch (Console.ReadLine())
                    {
                        case "a":
                            sum = firstNumber + secondNumber;
                            Console.WriteLine("By adding the two numbers " + firstNumber + " and " + secondNumber + "\n The total is :" + sum);
                            break;

                        case "s":
                            sum = firstNumber - secondNumber;
                            Console.WriteLine("By subtracting the number " + firstNumber + " with " + secondNumber + "\n The total is :" + sum);
                            break;

                        case "m":
                            sum = firstNumber * secondNumber;
                            Console.WriteLine("By multiplying the number " + firstNumber + " with " + secondNumber + "\n The total is :" + sum);
                            break;

                        case "d":
                            if (firstNumber == 0 || secondNumber == 0)
                            {
                                Console.WriteLine("Divide by zero exception!");
                            }
                            else
                            {
                                sum = firstNumber / secondNumber;
                                Console.WriteLine("By dividing the number " + firstNumber + " with " + secondNumber + "\n The total is :" + sum);

                            }
                            break;

                        case "e":
                            keepLooping = false;
                            //Environment.Exit(0);
                            //return; ??
                            // Application.Exit();  ??
                            break;

                        default:
                            Console.WriteLine("I don't know what you want!");
                            break;
                    }
                }

                catch (Exception ex)
                {
                    // Automate error message, built in.
                    Console.WriteLine("Error: " + ex.Message);

                }
            }

            // Keep doing above while keepLooping is true, basicly.
            while (keepLooping);
            {

            }

            static void MenuOptions() // My Menu for the calculator
            {
                // Ask the user to choose an option.
                Console.WriteLine("Choose from the following list what you want to do with the numbers:");
                Console.WriteLine("a - Add");
                Console.WriteLine("s - Subtract");
                Console.WriteLine("m - Multiply");
                Console.WriteLine("d - Divide");
                Console.WriteLine("e - Exit");
                Console.Write("What you want to do? ");
            }
        }
    }
}