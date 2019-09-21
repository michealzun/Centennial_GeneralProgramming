using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            testStack();
            testQueue();
            Console.ReadLine();
        }

        public static void testStack()
        {
            Console.WriteLine("--------stack test--------");
            StackIntLinkedList stackList = new StackIntLinkedList(1);
            stackList.push(2);
            stackList.push(3);
            stackList.print();
            int poppedvalue = stackList.pop();
            stackList.print();
            Console.WriteLine("popped value: " + poppedvalue);
        }

        public static void testQueue()
        {
            Console.WriteLine("--------queue test--------");
            QueueStringLinkedList stackList = new QueueStringLinkedList("a");
            stackList.enqueue("b");
            stackList.enqueue("c");
            stackList.print();
            string dequeuevalue = stackList.dequeue();
            stackList.print();
            Console.WriteLine("dequeue value: " + dequeuevalue);
        }
    }

    public class QueueStringNode
    {
        public string Data { get; private set; }
        public QueueStringNode Next { get; set; }
        public QueueStringNode(string data) { Data = data; }
        public override string ToString()
        {
            return Data;
        }
    }

    public class QueueStringLinkedList
    {
        private QueueStringNode last;
        private QueueStringNode curr;
        private QueueStringNode currNext;

        public QueueStringLinkedList(string data) {
            last = new QueueStringNode(data);
        }

        public void enqueue(string data)
        {
            QueueStringNode oldLast = last;
            last = new QueueStringNode(data);
            last.Next = oldLast;
        }
        public string dequeue()
        {
            curr = last;
            currNext = last.Next;
            while (currNext.Next != null)
            {
                curr = currNext;
                currNext = currNext.Next;
            }
            curr.Next = null;
            return currNext.ToString();
        }

        public void print()
        {
            string line = "";
            curr = last;
            while (curr.Next != null)
            {
                line += curr + " ";
                curr = curr.Next;
            }
            line += curr + " ";
            Console.WriteLine(line);
        }
    }

    public class StackIntNode
    {
        public int Data { get; private set; }
        public StackIntNode Next { get; set; }
        public StackIntNode(int data) { Data = data; }
        public override string ToString()
        {
            return Data.ToString();
        }
    }


    public class StackIntLinkedList
    {
        private StackIntNode last;
        private StackIntNode curr;

        public StackIntLinkedList(int data) { last = new StackIntNode(data); }

        public void push(int data)
        {
            StackIntNode oldLast = last;
            last = new StackIntNode(data);
            last.Next = oldLast;
        }
        public int pop()
        {
            int value = last.Data;
            if (last.Next != null)
            {
                last = last.Next;
            }
            return value;
        }
        
        public void print()
        {
            string line="";
            curr = last;
            while (curr.Next != null)
            {
                line += curr + " ";
                curr = curr.Next;
            }
            line += curr + " ";
            Console.WriteLine(line);
        }
    }

}
