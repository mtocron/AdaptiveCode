using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_strategy_pattern
{
    class Context
    {
        private IStrategy _CurrentStrategy;

        private readonly IStrategy _StrategyA = new ConcreteStrategyA();
        private readonly IStrategy _StrategyB = new ConcreteStrategyB();

        public Context()
        {
            _CurrentStrategy = _StrategyA;
        }

        public void DoSomething()
        {
            _CurrentStrategy.Execute();

            // 呼び出しごとに戦略（ストラテジー）を切り替える
            _CurrentStrategy = (_CurrentStrategy == _StrategyA) ? _StrategyB : _StrategyA;
        }
    }
}
