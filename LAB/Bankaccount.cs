using System;
using System.Collections.Generic;
using System.IO;

namespace LAB
{
    enum BankType
    {
        Сберегательный, Зарплатный
    }
    internal class Bankaccount
    {
        private static int accountCounter = 1;

        private int accountnumber;
        private double balance;
        private BankType type;
        private Queue<BankTransaction> transactionList = new Queue<BankTransaction>();




        public Bankaccount()
        {
            GenerateAccountNumber();
            accountnumber = accountCounter;

        }
        private void GenerateAccountNumber()
        {
            accountCounter++;
        }
        public Bankaccount(BankType type)
        {
            GenerateAccountNumber();
            accountnumber = accountCounter;
            this.type = type;
        }

        public Bankaccount(double balance)
        {
            GenerateAccountNumber();
            accountnumber = accountCounter;
            this.balance = balance;
        }

        public Bankaccount(BankType type, double balance)
        {
            GenerateAccountNumber();
            accountnumber = accountCounter;
            this.balance = balance;
            this.type = type;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                BankTransaction transaction = new BankTransaction(amount);
                transactionList.Enqueue(transaction);
                balance += amount;
                Console.WriteLine($"Депозит на {amount} успешно выполнен.\nНовый баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Сумма депозита должна быть больше нуля.");
            }
        }


        public void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                BankTransaction transaction = new BankTransaction(amount);
                transactionList.Enqueue(transaction);
                balance -= amount;
                Console.WriteLine($"Списание {amount} успешно выполнено.\nНовый баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        public void Transfer(Bankaccount account1, double amount)
        {
            BankTransaction transaction = new BankTransaction(amount);
            transactionList.Enqueue(transaction);
            account1.balance -= amount;
            balance += amount;
            Console.WriteLine($"Перевод на счёт {account1.accountnumber} выполнен, ваш текущий баланс {account1.balance}");
        }


        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountnumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {type}");
        }
        public void Dispose()
        {
                foreach (BankTransaction transactions in transactionList)
                {

                    File.WriteAllText("transactions.txt", transactions.Print());

                }
            GC.SuppressFinalize(this);

        }
    }
}
