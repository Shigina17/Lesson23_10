using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTM23_10
{
    public enum TypeOfBankAccount { Current, Saving }
    class Account
    {
        int Number;
        decimal Balance;
        TypeOfBankAccount TypeAccount;
        public int InfoNumber()
        {
            return Number;
        }
        public decimal InfoBalance()
        {
            return Balance;
        }
        public TypeOfBankAccount InfoTypeAccount()
        {
            return TypeAccount;
        }
        public void FillNumber(int number)
        {
            Number = number;
        }
        public void FillBalance(decimal balance)
        {
            Balance = balance;
        }

        public void FillTypeAccount(TypeOfBankAccount typeAccount)
        {
            TypeAccount = typeAccount;
        }
        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта: {TypeAccount}, Номер счёта: {Number}, Баланс: {Balance}");
        }
    }
}
