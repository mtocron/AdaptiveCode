using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_strategy_pattern
{
    class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyB.Execute()");
        }
    }
}
