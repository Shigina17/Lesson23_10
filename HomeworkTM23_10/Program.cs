using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTM23_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1");
            Random random = new Random();
            Account account = new Account();
            account.FillTypeAccount(TypeOfBankAccount.Current);
            account.FillNumber(random.Next(1, 99999999));
            account.FillBalance(100000);
            account.FullInfo();



            Console.WriteLine("Упражнение 7.2");
            Account2 account1 = new Account2();
            Account2 account2 = new Account2();
            Account2 account3 = new Account2();

            account1.FillTypeAccount(TypeOfBankAccount.Current);
            account1.FillBalance(100000);
            account1.FullInfo();
            account2.FullInfo();
            account3.FullInfo();



            Console.WriteLine("Упражнение 7.3");
            List<Account3> listAccount3 = new List<Account3>();
            Account3 account6 = new Account3
            {
                Balance = 10,
                Number = 5500,
                TypeAccount = TypeOfBankAccount.Current
            };

            listAccount3.Add(account6);

            Console.WriteLine(account6.Balance);
            Console.WriteLine(account6.Number);
            Console.WriteLine(account6.TypeAccount);

            foreach (var item in listAccount3)
            {
                item.FullInfo();
            }

            account6.DepositMoney(account6.Number, 325);
            account6.FullInfo();

            account6.WithdrawMoney(account6.Number, 99);
            account6.FullInfo();

            account6.WithdrawMoney(account6.Number, 455);
            account6.FullInfo();
            Console.ReadKey();
        
      

            Console.WriteLine("Домашнее задание 7.1");
            Building info = new Building(8, 20, 5, 100, 7);
            Console.WriteLine("Уникальный номер: " + info.Getnum_house());
            Console.WriteLine("Высота этажа: " + info.HeightFloor());
            Console.WriteLine("Количество квартир на этаже: " + info.AmountOfFlatsOnFloor());
            Console.WriteLine("Количество квартир в подъезде: " + info.AmountOfFlatsInEntrance());
            Console.ReadKey();
       }
    }
}



