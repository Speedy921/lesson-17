using lesson_17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    //защищеные данные состояния 
    partial class Employee
    {
        //Поля данных (производные классы теперь могут иметь прямой доступ к этой инф)
        protected string _empName;
        protected int _empId;
        protected float _currPay;
        protected int _empAge;
        protected string _empSSN;
        protected EmployeePayTypeEnum _payType;

        //содержит обьект BenefitPackage
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        //открывает доступ к некоторому поведению, связаному со льготами
        public double GetBenefitCost()
            => EmpBenefits.ComputePayDeduction();

        //этот класс может быть предопределен в производном классе
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        //открывает доступ к обьекту через специалное свойство 
        public BenefitPackage Benefits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        }

        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }

        //конструкторы 
        public Employee() { }
        public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }

        //методы 
        //public  void GiveBonus(float amount)
        //{
        //    Pay = this switch
        //    {
        //        { PayType: EmployeePayTypeEnum.Commissoin } => Pay += .10F * amount,
        //        { PayType: EmployeePayTypeEnum.Hourly } => Pay += .40F * amount / 2080F,
        //        { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount, _ => Pay += 0
        //    };
        //}
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name); //имя сотрудника
            Console.WriteLine("ID: {0}", Id); //инедетификационный номер сотрудника
            Console.WriteLine("Age^ {0}", Age); //возраст
            Console.WriteLine("Pay {0}", Pay); //текущая выплата
        }

        //Свойства
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Erorr! Name length exceeeds 15 characters!"); //ошибка! Длина имени превышает 15 символов!
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        //смешиванеи открытых и закрытых методов get/set в свойствах
        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
    }
}


