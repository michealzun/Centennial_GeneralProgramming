    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueyangSun_Lab5_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(300900111, "Alex");
            var list = new LinkedList<Student>();
            Student s2 = new Student(300900222, "James");
            Student s3 = new Student(300900333, "Sky");
            Student s4 = new Student(300900444, "Joe");
            Student s5 = new Student(300900555, "Ken");
            Student s6 = new Student(300900666, "Xxsdw");
            //a.
            list.AddFirst(s1);
            list.AddLast(s2);
            AddLinkedListItem(list, s3);
            AddLinkedListItem(list, s4);
            AddLinkedListItem(list, s5);
            PrintLinkedList(list);
            //b.
            RemoveLinkedListItem(list, s5);
            //c.
            PrintLinkedList(list);
            //d.
            String a= (SearchLinkedListItem(list, s1)) ? "s1 found in list" : "s1 not found in list";
            String b = (SearchLinkedListItem(list, s6)) ? "s6 found in list" : "s6 not found in list";
            Console.WriteLine(a);
            Console.WriteLine(b);
            //e
            RemoveAllLinkedListItems(ref list);
            Console.WriteLine("attepting to display list after clearing list:");
            PrintLinkedList(list);

            Console.ReadKey(); 
        }
        static void AddLinkedListItem<T>(LinkedList<T> list, T item) {
            list.AddLast(item);
        }
        static void RemoveLinkedListItem<T>(LinkedList<T> list, T item)
        {
            list.Remove(item);
        }
        static void PrintLinkedList<T>(LinkedList<T> list)
        {
            if (list.First != null)
            {
                LinkedListNode<T> curr = list.First;
                while (curr.Next != null)
                {
                    Console.Write($"{curr.Value} ");
                    curr = curr.Next;
                }
                Console.Write($"{curr.Value} ");
                Console.WriteLine("\n");
            }
            else { Console.WriteLine("null list"); }
        }
        static bool SearchLinkedListItem<T>(LinkedList<T> list, T item)
        {
            LinkedListNode<T> node=list.Find(item);
            if (node == null) { return false; } else { return true; }
        }
        static void RemoveAllLinkedListItems<T>(ref LinkedList<T> list)
        {
            list = new LinkedList<T>();
        }
    }
    class Student 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student(int id, String name)
        {
            ID = id;
            Name = name;
       }
       public override string ToString()
       {
          return String.Format("\nID: {0}, Name:{1}",ID.ToString(), Name); 
       }
    }
}
