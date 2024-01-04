// See https://aka.ms/new-console-template for more information

using Method_Overload;
using System.ComponentModel;
using System.Data;
using System.Xml.Linq;

Employee employee = new Employee();
employee.Name = "Kristian";
employee.Salary = 10000;
Employee employee2 = new Employee();
employee2.Name = "Robert";
employee2.Salary = 15000;
bool result = employee.Salary > employee2.Salary;
Console.WriteLine(result);
Employee employee3 = new Employee();
employee3.Salary = employee.Salary + employee2.Salary;
Console.WriteLine(employee3.Salary);
Employee employee4 = new Employee();
employee4 = ++employee;
Console.WriteLine(employee4.Salary);
Employee employee5 = new Employee() {Salary=50000 };
    if (employee5)
        Console.WriteLine(true);
    else
        Console.WriteLine(false);
    if(!employee5)
        Console.WriteLine(true);
    else
        Console.WriteLine(false);
    Console.WriteLine("\t");

City Kharkiv = new City() { Residents = 1421125 };
City Kyiv = new City() { Residents = 2952301 };
bool result2 = Kharkiv > Kyiv;
Console.WriteLine(result2);
City KharkivKyiv = Kharkiv + Kyiv;
Console.WriteLine(KharkivKyiv.Residents);
City KharkivMore= ++Kharkiv;
Console.WriteLine(KharkivMore.Residents);
City Lviv = new City() { Residents = 717273 };
    if (Lviv)
        Console.WriteLine(true);
    else
        Console.WriteLine(false);
    if (!Lviv)
        Console.WriteLine(true);
    else
        Console.WriteLine(false);
    Console.WriteLine("\t");

CreditCard PrivateCard = new CreditCard() { Sum= 5000};
CreditCard PrivateUniversal = new CreditCard() { Sum = 13500 };
CreditCard SumOfPrivate = PrivateCard + PrivateUniversal;
Console.WriteLine(SumOfPrivate.Sum);
bool result3 = PrivateCard > PrivateUniversal;
Console.WriteLine(result3);
CreditCard PrivateMore = ++PrivateCard;
Console.WriteLine(PrivateMore.Sum);
CreditCard Mono = new CreditCard() { Sum = 30000 };
    if (Mono)
        Console.WriteLine(true);
    else
        Console.WriteLine(false);
    if (!Mono)
        Console.WriteLine(true);
    else 
        Console.WriteLine(false);

Console.WriteLine("\t");


Console.Write("Enter the amount of rows: ");
var IfInt = int.TryParse(Console.ReadLine(), out int rows);
if (!IfInt)
    throw new ArgumentException("Sorry, enter the number");
Console.Write("Enter the amount of columns: ");
var IfInt2 = int.TryParse(Console.ReadLine(), out int columns);
if (!IfInt2)
    throw new ArgumentException("Sorry, enter the number");
var matrix = new int[rows,columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = random.Next(0, 11);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write(String.Format("{0,3}", matrix[i, j]));
        Console.WriteLine();
    }
var matrix2 = new int[rows,columns];
Random random2 = new Random();
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        matrix[i, j] = random2.Next(0, 11);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write(String.Format("{0,3}", matrix[i, j]));
    Console.WriteLine();
}




