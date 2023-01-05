using Lesson_17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_17
{
    sealed class PtSalesPerson: SalesPerson
    {
        public int SalesNumber { get; set; }

        //все подкласы должны явно вызывать подходящй конструктор базового класса
        public PtSalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empId, currPay, ssn, numbOfSales)
        {
        }

        public PtSalesPerson() { }
    }
}
