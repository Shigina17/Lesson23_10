using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTM23_10
{
    class Account3
    {
        static int counter = 1;
        int number_;
        public int Number
        {
            get
            {
                return number_;
            }
            set
            {
                if (value.GetType().ToString() == "System.Int32")
                {
                    number_ = value;
                }
            }
        }
        decimal balance_;
        public decimal Balance
        {
            get
            {
                return balance_;
            }
            set
            {
                if (value.GetType().ToString() == "System.Decimal")
                {
                    balance_ = value;
                }
            }
        }
        TypeOfBankAccount typeAccount_;
        public TypeOfBankAccount TypeAccount
        {
            get
            {
                return typeAccount_;
            }
            set
            {
                if (value.GetType().ToString() == "GB_04_02BankAccount04.TypeOfBankAccount")
                {
                    typeAccount_ = value;
                }
            }
        }
        public Account3()
        {
            number_ = Increase();
        }
        public Account3(decimal balance)
        {
            balance_ = balance;
            number_ = Increase();
        }
        public Account3(TypeOfBankAccount typeAccount)
        {
            typeAccount_ = typeAccount;
            number_ = Increase();
        }
        public Account3(decimal balance, TypeOfBankAccount typeAccount)
        {
            balance_ = balance;
            typeAccount_ = typeAccount;
            number_ = Increase();
        }
        int Increase()
        {
            return counter++;
        }
        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта: {typeAccount_}, Номер счёта: {number_}, Баланс: {balance_}");
        }
        /// <summary>
        /// Положить на счет
        /// </summary>
        /// <param name="number">Номер счёта</param>
        /// <param name="put">Положить сумму</param>
        public void DepositMoney(int number, decimal put)
        {
            if (number == number_)
            {
                balance_ = balance_ + put;
                Console.WriteLine($"Счёт пополнен на: {put}");
            }
        }
        /// <summary>
        /// Снять со счета
        /// </summary>
        /// <param name="number">Номер счёта</param>
        /// <param name="take">Снятия сумму</param>
        public void WithdrawMoney(int number, decimal take)
        {
            if (number == number_)
            {
                if (balance_ >= take)
                {
                    balance_ = balance_ - take;

                    Console.WriteLine($"Со счёта снято: {take}");
                }
                else
                    Console.WriteLine($"На счету недостаточно средств. Баланс: {balance_}; Сумма для снятия: {take};");
            }
        }
    }
}
