using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_interface_definition
{
    // メソッドのシグネチャは、メソッドの名前とパラメータリストで構成される
    public class ClashingMethodSignatures
    {
        public void MethodA()
        {

        }

        // 上のメソッドと競合
        //public void MethodA()
        //{

        //}

        // 同上：戻り値は考慮されない
        //public int MethodA()
        //{
        //    return 0;
        //}

        // メソッドのアクセスレベル、戻り値、abstract修飾子、sealed修飾子は
        // どれもメソッドのシグネチャに影響を与える？

        public int MethodB(int x)
        {
            return x;
        }

        // パラメータが異なるため、競合しない　MethodBのオーバーロード
        public int MethodB(int x, int y)
        {
            return x + y;
        }
    }
}
