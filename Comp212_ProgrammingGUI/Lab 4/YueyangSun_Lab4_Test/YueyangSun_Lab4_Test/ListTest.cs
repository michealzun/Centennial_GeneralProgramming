// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;
using LinkedListLibraryEx1;

// class to test List class functionality
static class ListTest
{
    public static void test()
    {
        var list = new List(); // create List container

        list.InsertAtBack(1);
        list.InsertAtBack(2);
        list.InsertAtBack(3);
        list.InsertAtBack(3.5);
        Console.WriteLine("enter double to search");
        double search = Convert.ToDouble(Console.ReadLine());
        if (list.search(search))
        { Console.WriteLine("found"); }
        else
        { Console.WriteLine("not found"); }
        Console.WriteLine(list.count().ToString() + " values found in list");
        Console.WriteLine(list.sum().ToString() + " sum");
        Console.ReadLine();
    }
}

