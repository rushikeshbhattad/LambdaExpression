using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class EmployeeLambda
    {
        public string EmpID;
        public string Name;
    }
    class LambdaDemo
    {
        internal void LambdaFun()
        {
            List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Orignal list");
            foreach (int n in li)
            {
                Console.WriteLine(n);
            }
            List<int> EvenNums = li.FindAll(x => (x % 2) == 0);//FindAll elements if the condition is true
            Console.WriteLine("List of even numbers");
            foreach (int n in EvenNums)
            {
                Console.WriteLine(n);
            }
            var SqNums = li.Select(x => x * x);//Can be used as an assignment operator in list
            Console.WriteLine("Square of all numbers");
            foreach (int n in SqNums)
            {
                Console.WriteLine(n);
            }
        }
        internal void EmpLambda()
        {
            List<EmployeeLambda> Employee = new List<EmployeeLambda>()
            {
                new EmployeeLambda{EmpID = "E1", Name = "ABC"},
                new EmployeeLambda{EmpID = "E2", Name = "XYZ"},
                new EmployeeLambda{EmpID = "E3", Name = "PQR"},
            };
            IEnumerable names = Employee.Select(x => x.Name);
            Console.WriteLine("Names of all employees");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LambdaDemo ld = new LambdaDemo();
            ld.LambdaFun();
            ld.EmpLambda();
            Console.ReadKey();
        }
    }
}