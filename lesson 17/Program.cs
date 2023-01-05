using lesson_17;
using Lesson_17;

Console.WriteLine("*****Fun with Encapsulation****\n");
Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeePayTypeEnum.Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(1000);
Console.WriteLine(emp.Pay);

//Использовать методы get/set для взаимодействия
//с именем сотрудника, предоставленого обьектом
emp.Name = "Marv";
Console.WriteLine("Employee is named: {0}", emp.Name);
Console.ReadLine();

//Длина 15  символов! На консоль выводится сообщение об ошибке.
Employee emp2 = new Employee();
emp2.Name = "Xena the warrior princess";
Console.ReadLine();

Employee joe = new Employee();
joe.Age++;

Console.ReadLine();

Console.WriteLine("*****The Employee Class Hierarchy*****\n");
SalesPerson fred = new SalesPerson
{
    Age = 31,
    Name = "Fred",
    SalesNumber = 50
};


Console.ReadLine();

Console.WriteLine("The Employee Class Hierarchy");

Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
double cost = chucky.GetBenefitCost();
Console.WriteLine($"Benefit Cost:{cost}");
Console.ReadLine();

Console.WriteLine("*****The Employee Class Hierarchy*****\n");
Manager chucky2 = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
chucky2.GiveBonus(300); 
chucky.DisplayStats();
Console.WriteLine();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
fran.GiveBonus(200);
fran.DisplayStats();
Console.ReadLine();

