// Fig. 19.4: LinkedListLibrary.cs
// ListNode, List and EmptyListException class declarations.
using System;

namespace LinkedListLibraryEx3
{
   // class to represent one node in a list
   class ListNode
   {
      // automatic read-only property Data
      public string Data { get; private set; }

      // automatic property Next
      public ListNode Next { get; set; }

      // constructor to create ListNode that refers to dataValue
      // and is last node in list
      public ListNode(string dataValue) : this(dataValue, null) { }

      // constructor to create ListNode that refers to dataValue
      // and refers to next ListNode in List
      public ListNode(string dataValue, ListNode nextNode)
      {
         Data = dataValue;
         Next = nextNode;
      }
        //reuturn true if we can find the value given
     
   }

   // class List declaration
   public class List
   {
      private ListNode firstNode;
      private ListNode lastNode;
      private string name; // string like "list" to display

      // construct empty List with specified name
      public List(string listName)
      {
         name = listName;
         firstNode = lastNode = null;
      }

      // construct empty List with "list" as its name 
      public List() : this("list") { }

      // Insert object at front of List. If List is empty, 
      // firstNode and lastNode will refer to same object.
      // Otherwise, firstNode refers to new node.
      public void InsertAtFront(string insertItem)
      {
         if (IsEmpty())
         {
            firstNode = lastNode = new ListNode(insertItem);
         }
         else
         {
            firstNode = new ListNode(insertItem, firstNode);
         }
      }

      // Insert object at end of List. If List is empty, 
      // firstNode and lastNode will refer to same object.
      // Otherwise, lastNode's Next property refers to new node.
      public void InsertAtBack(string insertItem)
      {
         if (IsEmpty())
         {
            firstNode = lastNode = new ListNode(insertItem);
         }
         else
         {
            lastNode = lastNode.Next = new ListNode(insertItem);
         }
      }

      // remove first node from List
      public object RemoveFromFront()
      {
         if (IsEmpty())
         {
            throw new EmptyListException(name);
         }

         object removeItem = firstNode.Data; // retrieve data

         // reset firstNode and lastNode references
         if (firstNode == lastNode)
         {
            firstNode = lastNode = null;
         }
         else
         {
            firstNode = firstNode.Next;
         }

         return removeItem; // return removed data
      }

      // remove last node from List
      public object RemoveFromBack()
      {
         if (IsEmpty())
         {
            throw new EmptyListException(name);
         }

            string removeItem = lastNode.Data; // retrieve data

         // reset firstNode and lastNode references
         if (firstNode == lastNode)
         {
            firstNode = lastNode = null;
         }
         else
         {
            ListNode current = firstNode;

            // loop while current.Next is not lastNode
            while (current.Next != lastNode)
            {
               current = current.Next; // move to next node
            }

            // current is new lastNode
            lastNode = current;
            current.Next = null;
         }

         return removeItem; // return removed data
      }

      // return true if List is empty
      public bool IsEmpty()
      {
         return firstNode == null;
      }

        // output List contents
        public string Display()
        {
            string output;
            if (IsEmpty())
            {
                output = "no display";
                return output;
            }
            else
            {
                output = ($"The {name} is: ");

                ListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    output += current.Data.ToString();
                    current = current.Next;
                }

                return output;
            }
        }
    }


   // class EmptyListException declaration
   public class EmptyListException : Exception
   {
      // parameterless constructor
      public EmptyListException() : base("The list is empty") { }

      // one-parameter constructor
      public EmptyListException(string name)
         : base($"The {name} is empty") { }

      // two-parameter constructor
      public EmptyListException(string exception, Exception inner)
         : base(exception, inner) { }
   }
}


