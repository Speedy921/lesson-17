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
    }
}
