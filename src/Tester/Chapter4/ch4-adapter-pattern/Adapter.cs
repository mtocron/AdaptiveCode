using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_adapter_pattern
{
    public class Adapter : Adaptee
    {
        // Class Adapterパターン

        // アダプター（実装）としての継承を利用する
        // →クライアントが期待しているインタフェースを、ターゲットクラスのサブクラスに適応させる必要がある

        public void MethodA()
        {
            MethodB();
        }
    }
}
