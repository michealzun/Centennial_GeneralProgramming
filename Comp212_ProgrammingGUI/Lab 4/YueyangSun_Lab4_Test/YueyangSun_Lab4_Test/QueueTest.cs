// Fig. 19.17: QueueTest.cs
// Testing class QueueInheritance.
using System;
using QueueInheritanceLibrary;
using LinkedListLibraryEx2;

// demonstrate functionality of class QueueInheritance
static class QueueTest
{
   public static void test()
   {
      QueueInheritance queue = new QueueInheritance();
      queue.Enqueue("aaa");
        Console.WriteLine(queue.Display());
      queue.Enqueue("bbb");
        Console.WriteLine(queue.Display());
        queue.Enqueue("ccc");
        Console.WriteLine(queue.Display());
        queue.Dequeue();
        Console.WriteLine(queue.Display());
        queue.Dequeue();
        Console.WriteLine(queue.Display());
        Console.ReadKey();
    
    }
}

