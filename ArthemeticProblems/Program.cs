using System;

namespace ArthemeticProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Performing Arthematic Operation");
            Addition addition = new Addition();
            int addResult= addition.AdditionMethod(2, 4);
            Console.WriteLine(addResult);
        }
    }
}
