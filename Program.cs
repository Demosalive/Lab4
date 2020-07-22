using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();

            
            string answer = "y";
            while (answer == "y")
            {
                Console.Write("Enter and integer: ");
                int integer = int.Parse(Console.ReadLine());
                
                {
                    Console.WriteLine();
                    Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
                    Formula(integer);
                    //for (int i = 1; i <= integer; i++)
                    //{
                    //    Console.WriteLine(i + "\t" + (i * i) + "\t" + (i * i * i));
                    //}
                }

                Console.WriteLine();
                Console.WriteLine("Continue?(y/n)");
                answer = Console.ReadLine().ToLower();
            }
            

        }
    public static void Formula(int integer)
        {
            for (int i = 1; i <= integer; i++)
            {
                Console.WriteLine(i + "\t" + (i * i) + "\t" + (i * i * i));
            }
        }
    }
}
