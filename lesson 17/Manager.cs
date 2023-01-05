using Lesson_17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_17
{
    //менеджерам нужно знать кол их фондовых опционов
    class Manager: Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbofOpts)
            : base (fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
        {
            //это свойство определено в классе Manager.
            StockOptions = numbofOpts;
        }

        public Manager() { }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            //вывод количетсва фондорвых опционов
            Console.WriteLine("Number of Stock OPtions: {0}", StockOptions);
        }


    }
}
