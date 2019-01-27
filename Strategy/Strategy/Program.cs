using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategy strategy = GetStrategy(Algorithms.Algtms.Algorithm1);
            strategy.ExecuteAlgorithm("value 1");

            strategy = GetStrategy(Algorithms.Algtms.Algorithm2);
            strategy.ExecuteAlgorithm("value 1");

            Console.ReadKey();
        }

        static IStrategy GetStrategy(Algorithms.Algtms algorithm)
        {
            switch (algorithm)
            {
                case Algorithms.Algtms.Algorithm1:
                    return new Algorithm1();
                case Algorithms.Algtms.Algorithm2:
                    return new Algorithm2();
                default:
                    return new Algorithm1();
            }
        }
    }
}
