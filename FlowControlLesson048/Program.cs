using System;

namespace FlowControlLesson048
{
    class MainClass
    {

        public static void DoExercise_1()
        {
            Console.WriteLine("Exercise 1 done");
        }

        public static void Main(string[] args)
        {
            bool quit = false;

            while(!quit)
            {
                Console.WriteLine("1. Divisible by 3");
                int exerciseNr = int.Parse(Console.ReadLine());

                switch(exerciseNr)
                {
                    case 1:
                        DoExercise_1();
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
