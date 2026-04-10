using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11 //課題32-20ポリモーフィズム
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Employee(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public abstract double CalculateDailyWage(double hoursWorked);

    }
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string id, string name)
            :base(id, name) { }
        public override double CalculateDailyWage(double hoursWorked)
        {
            if (hoursWorked <= 8)
            {
                return 1250 * hoursWorked; //通常
            }
            else
            {
                return (1250 * 8) + ((hoursWorked - 8) * 1250 * 1.25); //通常＋残業
            }
        }
    }
    public class ContractEmployee : Employee
    {
        public ContractEmployee(string id, string name)
            :base(id, name) { }
        public override double CalculateDailyWage(double hoursWorked)

        {
            return 1000 * hoursWorked; //固定計算
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee("E001", "山田太郎"));
            employees.Add(new ContractEmployee("C001", "佐藤花子"));
            employees.Add(new FullTimeEmployee("E002", "鈴木一郎"));

            foreach (Employee emp in employees) 
            {
                double hours;

                if (emp.Id == "E001")
                {
                    hours = 8.5;  
                }
                else
                {
                    hours = 8;
                }

                double wage = emp.CalculateDailyWage(hours); //処理

                Console.WriteLine($"社員ID: {emp.Id}, 名前: {emp.Name}, 給料: {(int)wage}"); 
                //社員ID: E001, 名前: 山田太郎, 給料: 10781
                //社員ID: C001, 名前: 佐藤花子, 給料: 8000
                //社員ID: E002, 名前: 鈴木一郎, 給料: 10000
            }
        }
    }
}
