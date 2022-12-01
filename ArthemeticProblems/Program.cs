using System;

namespace ArthemeticProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Performing Arthematic Operation");
            

            while (true)
            {
                Console.WriteLine("Enter the option to perform the operation \n1) Addition \n2) Subraction");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Addition addition = new Addition();
                        int addResult = addition.AdditionMethod(2, 4);
                        Console.WriteLine(addResult);
                        break;
                    case 2:
                        int subResult = Subraction.SubractionMethod(5, 8);
                        Console.WriteLine("Result of subraction is :"+ subResult);
                        break;
                }
            }


        }
    }
}
