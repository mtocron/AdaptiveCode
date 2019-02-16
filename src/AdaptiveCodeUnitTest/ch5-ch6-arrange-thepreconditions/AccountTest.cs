using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.Chapter5;

namespace AdaptiveCodeUnitTest.ch5_ch6_arrange_thepreconditions
{
	[TestClass]
	public class AccountTest
	{
		[TestMethod]
		public void AddingTransactionChangesBalance()
		{
			// Arrange … テストの事前条件のセットアップ
			var account = new Account();

			// Act … テストの対象となるアクションの実行（省略可能）
			account.AddTransaction(200m);

			// Assert … 振る舞いが期待どおりであることの検証
			Assert.AreEqual(200m, account.Balance);
		}
	}
}
