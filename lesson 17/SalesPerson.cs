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
    }
}
