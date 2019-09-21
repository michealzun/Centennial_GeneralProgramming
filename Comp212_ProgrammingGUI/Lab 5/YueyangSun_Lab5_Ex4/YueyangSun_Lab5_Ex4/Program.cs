using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueyangSun_Lab5_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //a.
            SortedDictionary<int, Employee> dictionary = new SortedDictionary<int, Employee>();
            Employee e1 = new Employee("a", 1000);
            Employee e2 = new Employee("b", 2000);
            Employee e3 = new Employee("c", 3000);
            Employee e4 = new Employee("d", 4000);
            Employee e5 = new Employee("e", 5000);
            //both the original and modified version(which just calls the original) works
            dictionary.Add(1, e1);
            AddDictionaryItem(dictionary, e2);
            dictionary.Add(3, e3);
            AddDictionaryItem(dictionary, e4);
            dictionary.Add(5, e5);
            PrintDictionary(dictionary);
            //b.
            RemoveDictionaryItem(dictionary, 1);
            //c.
            Console.WriteLine("after removal of key 1");
            PrintDictionary(dictionary);
            //d.
            int index = SearchDictionaryItem(dictionary, e3);
            Console.WriteLine("search for key of  employee e3  -  Key: " + index);
            //e.
            int max = MaxDictionaryItem(dictionary);
            Console.WriteLine("emp with highest salary is key: " +max +", "+ dictionary[max]);

            Console.ReadKey();
        }
        static void AddDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            int key = var.Count + 1;
            var.Add(key, emp);
        }
        static void RemoveDictionaryItem(SortedDictionary<int, Employee> var,int key)
        {
            var.Remove(key);
        }
        static void PrintDictionary(SortedDictionary<int, Employee> var)
        {
            foreach (var key in var.Keys)
            {
                Console.WriteLine($"key: {key}, {var[key]}");
            }
        }
        static int SearchDictionaryItem(SortedDictionary<int, Employee> var, Employee emp)
        {
            int index = -1;
            foreach (KeyValuePair<int,Employee> x in var)
            {
                if (x.Value.Equals(emp))
                {
                    index = x.Key;
                }
            }
            return index;
        }
        static int MaxDictionaryItem(SortedDictionary<int, Employee> var) {
            int index = -1;
            double highest = 0;
            foreach (KeyValuePair<int, Employee> x in var)
            {
                if (x.Value.Salary>highest)
                {
                    highest = x.Value.Salary;
                    index = x.Key;
                }
            }
            return index;
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(String name, double salary)
        {
            Name = name;
            Salary=salary;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Salary: {1}", Name,Salary.ToString());
        }
    }
}
