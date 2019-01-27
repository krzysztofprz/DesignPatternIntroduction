using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Algorithm2 : IStrategy
    {
        public void ExecuteAlgorithm(string someInput)
        {
            Console.WriteLine($"Executing Algorithm2 for input: {someInput}");
        }
    }
}
