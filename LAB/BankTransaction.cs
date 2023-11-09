using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class BankTransaction
    {
        public DateTime transactionDate;
        public readonly double money;

        public BankTransaction(double money)
        {
            transactionDate = DateTime.Now;
            this.money = money;
        }
        public string Print()
        {
            return ($"Время операции: {transactionDate}\nСумма операции: {money} рублей");
        }
    }
}
