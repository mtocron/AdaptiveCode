using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Chapter5
{
	/// <summary> 顧客の口座の残高と取引を表すクラス </summary>
	public class Account
	{
		/// <summary> 残高 </summary>
		public decimal Balance { get; private set; }

		public Account()
		{
		}

		public void AddTransaction(decimal amount)
		{
			Balance += amount;
		}
	}
}