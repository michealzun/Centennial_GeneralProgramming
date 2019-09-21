// Fig. 19.13: StackInheritanceLibrary.cs
// Implementing a stack by inheriting from class List.
using LinkedListLibraryEx2;
using System;

namespace StackInheritanceLibrary
{
   // class StackInheritance inherits class List's capabilities
   public class StackInheritance : List
   {
      // pass name "stack" to List constructor
      public StackInheritance() : base("stack") { }

      // place dataValue at top of stack by inserting 
      // dataValue at front of linked list
      public void Push(double dataValue)
      {
         InsertAtFront(dataValue);
      }

      // remove item from top of stack by removing
      // item at front of linked list
      public object Pop()
      {
         return RemoveFromFront();
      }

        public object Peek()
        {
            object frontObject = RemoveFromFront();
            InsertAtFront(Convert.ToDouble(frontObject));
            return frontObject;
        }
    }
}

