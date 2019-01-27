using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Algorithm1 : IStrategy
    {
        void IStrategy.ExecuteAlgorithm(string someInput)
        {
            Console.WriteLine($"Executing Algorithm1 for input: {someInput}");
        }
    }
}
