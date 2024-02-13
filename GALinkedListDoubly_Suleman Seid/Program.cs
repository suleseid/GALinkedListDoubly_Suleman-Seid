using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GALinkedListDoubly_Suleman_Seid
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();
            // Create a DoublyLinkedList of strings (names)
            DoublyLinkedList<string> nameList = new DoublyLinkedList<string>();
            // Add elements
            linkedList.Add(3);
            linkedList.Add(100);
            linkedList.Add(7);

            // Display forward and backward
            //Console.WriteLine("Forward:");
            Console.WriteLine("Linked List (Forward):");
            linkedList.DisplayForward();
            Console.WriteLine("Linked List (Backward):");
            linkedList.DisplayBackward();


            // Add more elements
            linkedList.Add(15);
            linkedList.Add(49);
            linkedList.InsertAtIndex(1, 55); // Insert 55 at index 1
            // Display the updated list
            Console.WriteLine("Linked List after adding more elements:");
            linkedList.DisplayForward();

            // Add names to the list
            nameList.Add("Alice");
            nameList.Add("Bob");
            nameList.Add("Charlie");

            nameList.Add("Mahome"); 

            // Display the list forward
            Console.WriteLine("Names in the list:");
            nameList.DisplayForward();


            // Remove an element
            linkedList.Remove(100);
            Console.WriteLine("100 removed");
            nameList.Remove("Bob");
            Console.WriteLine("Bob removed");


            // Display the list forward
            Console.WriteLine("Names in the list:");
            nameList.DisplayForward(); 

            // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            //// Insert elements at specific positions
            //linkedList.InsertAtIndex(1, 55); // Insert 55 at index 1
            //linkedList.InsertAtFront(3);     // Insert 3 at the beginning
            //linkedList.InsertAtEnd(7);      // Insert 7 at the end

            //// Display forward after insertion
            //Console.WriteLine("Forward (after insertion):");
            //linkedList.DisplayForward();

            //// Remove elements at specific positions
            //linkedList.RemoveAtFront(); // Remove the first element
            //linkedList.RemoveAtEnd();   // Remove the last element
            //linkedList.RemoveAtIndex(2); // Remove the element at index 2

            //// Display forward after removal
            //Console.WriteLine("Forward (after removal):");
            //linkedList.DisplayForward();

            //// Clear the linked list
            //linkedList.Clear();

            //// Display forward after clearing
            //Console.WriteLine("Forward (after clearing):");
            //linkedList.DisplayForward();

            //Console.ReadLine();
        }
    }
}
