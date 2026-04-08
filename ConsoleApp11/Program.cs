using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11 //課題32-20ポリモーフィズム
{
    public abstract class Employee
    {
        public Employee(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
