using System;

namespace FlowControlLesson048
{
    class MainClass
    {
        public static int CalculateFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }

            int result = number;
            for (int i = number - 1; i > 0; i--)
            {
                result *= i; 
            }

            return result;
        }

        public static int GetMaxValue(int[] values)
        {
            int maxValue = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                {
                    maxValue = values[i];
                }
                else
                {
                    maxValue = maxValue < values[i] ? values[i] : maxValue;
                }
            }

            return maxValue;
        }

        public static void DoExercise_1()
        {
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("Between 1 and 100 there are {0} divisible by 3 with no remainder", counter);
        }

        public static void DoExercise_2()
        {
            int sum = 0;
            while(true)
            {
                Console.Write("Enter a number or \'ok\' to quit: ");
                string answer = Console.ReadLine().ToLower();
                if(answer == "ok")
                {
                    Console.WriteLine("The sum of the entered values is {0}", sum);
                    break;
                }
                int number = int.Parse(answer);
                sum += number;
            }
        }

        public static void DoExercise_3()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int result = CalculateFactorial(number);
            Console.WriteLine("The factorial of {0} is {1}", number, result);
        }

        public static void DoExercise_4()
        {
            Console.WriteLine("Guess a number between one and 10!");
            Random random = new Random();
            int randomValue = random.Next(1, 10);

            int times = 0;
            bool won = false;
            do
            {
                times++;
                Console.Write("Guess {0}: ", times);
                int guess = int.Parse(Console.ReadLine());
                if(guess == randomValue)
                {
                    won = true;
                    break;
                }
            } while (times < 4);

            if(won){
                Console.WriteLine("You won!!!");
            }
            else
            {
                Console.WriteLine("You lost!!! The value was {0}", randomValue);
            }
        }

        public static void DoExercise_5()
        {
            Console.Write("Write a series of numbers separated by coma e.g 1,2,3,4: ");
            string[] values = Console.ReadLine().Split(',');
            int[] iValues = Array.ConvertAll<string, int>(values, int.Parse);

            int maxValue = GetMaxValue(iValues);
            Console.WriteLine("Max value is {0}", maxValue);
        }

        public static void Main(string[] args)
        {
            bool quit = false;

            while(!quit)
            {
                Console.WriteLine("1. Divisible by 3\n2. Enter a number\n3. Calculate factorial\n4. Random number\n5. Find max value");
                int exerciseNr = int.Parse(Console.ReadLine());

                switch(exerciseNr)
                {
                    case 1:
                        DoExercise_1();
                        break;
                    case 2:
                        DoExercise_2();
                        break;
                    case 3:
                        DoExercise_3();
                        break;
                    case 4:
                        DoExercise_4();
                        break;
                    case 5:
                        DoExercise_5();
                        break;
                    default:
                        Console.WriteLine("Exercise {0} unavailable", exerciseNr);
                        break;
                }

                Console.Write("Quit? (y/n): ");
                string answer = Console.ReadLine().ToLower();
                quit = answer == "y";
            }
        }
    }
}
