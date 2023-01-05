using Lesson_17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_17
{
    //Продавцам нужно знать количество продаж
    class SalesPerson: Employee
    {
        public int SalesNumber { get; set; }

        //все подкласы должны явно вызывать подходящй конструктор базового класса
        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commissoin)
        {
            SalesNumber = numbOfSales;
        }

       public SalesPerson() { }

        //бонус продавца зависит от количества продаж 
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if(SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;

            }
            base.GiveBonus(amount*salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            //вывод количетва продаж
            Console.WriteLine("Number of sales: {0}", SalesNumber);
        }
    }
}
