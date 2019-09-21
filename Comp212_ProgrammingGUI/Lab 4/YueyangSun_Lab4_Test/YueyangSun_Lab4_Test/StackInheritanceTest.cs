// Fig. 19.14: StackInheritanceTest.cs
// Testing class StackInheritance.
using System;
using StackInheritanceLibrary;
using LinkedListLibraryEx3;

// demonstrate functionality of class StackInheritance
static class StackInheritanceTest
{
   public static void test()
   {
      StackInheritance stack = new StackInheritance();

      stack.Push(1);
        Console.WriteLine(stack.Display());
      stack.Push(2);
        Console.WriteLine(stack.Display()); stack.Display();
      stack.Pop();
        Console.WriteLine(stack.Display());
        double peekValue=Convert.ToDouble(stack.Peek());
        Console.WriteLine("peek result: " + stack.Peek());
        Console.WriteLine(stack.Display());
        Console.ReadKey();
     
   }
}

