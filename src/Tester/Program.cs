using System;
using Tester.Chapter4.ch4_adapter_pattern;

namespace Tester
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ObjectAdapterPattern();

            Console.ReadKey();
        }

        #region Object Adapterパターン
        private static IExpectedInterface _Adapter = new ObjectAdapter(new TargetClass());
        private static void ObjectAdapterPattern()
        {
            _Adapter.MethodA();
        }
        #endregion

    }
}
