using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter4.ch4_null_object_pattern_isnull_anti_pattern
{
    class NullUser : IUser
    {
        // このプロパティを参照するときに例外が発生する
        // public string Name => throw new NotImplementedException();

        // nullユーザーの名前をカプセル化する
        public string Name => "Unknown";

        // カプセル化を目的としているオブジェクトからロジックがこぼれ出てしまう
        // クライアントコードでif文が発生する
        public bool IsNull => true;

        public void IncrementSessionTicket()
        {
            // 何もしない
        }
    }
}
