using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GALinkedListDoubly_Suleman_Seid
{
    public class DoublyLinkedList<T>
    {
        // Nested class LinkedListNode representing elements in the doubly linked list.
        class LinkedListNode<T>
        {
            public T Value { get; set; } // Data stored in the node.
            public LinkedListNode<T> Next { get; set; }     // Reference to the next node.
            public LinkedListNode<T> Previous { get; set; } // Reference to the previous node.

            public LinkedListNode(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }

        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        public void RemoveAtFront()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty. Cannot remove from the front.");
                return;
            }

            head = head.Next;
            if (head != null)
                head.Previous = null;

            count--;
        }

        public void RemoveAtEnd()
        {
            if (tail == null)
            {
                Console.WriteLine("The list is empty. Cannot remove from the end.");
                return;
            }

            tail = tail.Previous;
            if (tail != null)
                tail.Next = null;

            count--;
        }

        // Display elements from head to tail.
        public void DisplayForward()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        // Display elements from tail to head.
        public void DisplayBackward()
        {
            LinkedListNode<T> current = tail;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Previous;
            }
            Console.WriteLine();
        }

        // Remove an element by value.
        public bool Remove(T value)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current == head) head = head.Next;
                    if (current == tail) tail = tail.Previous;
                    if (current.Next != null) current.Next.Previous = current.Previous;
                    if (current.Previous != null) current.Previous.Next = current.Next;

                    count--;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        // Access elements by index using an indexer.
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                LinkedListNode<T> current = head;
                for (int i = 0; i < index; i++)
                    current = current.Next;

                return current.Value;
            }
        }

        // Insert an element at a specific index.
        public void InsertAtIndex(int index, T value)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (index == 0)
            {
                newNode.Next = head;

                if (head != null)
                {
                    head.Previous = newNode;
                }
            }
            else
            {
                LinkedListNode<T> current = head;
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                newNode.Next = current.Next;
                newNode.Previous = current;
                current.Next = newNode;

                if (newNode.Next != null)
                    newNode.Next.Previous = newNode;
            }

            count++;
        }

        // Insert an element at the beginning of the list.
        public void InsertAtFront(T value)
        {
            InsertAtIndex(0, value);
        }

        // Insert an element at the end of the list.
        public void InsertAtEnd(T value)
        {
            InsertAtIndex(count, value);
        }

        // Remove an element at a specific index.
        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            LinkedListNode<T> current = head;

            if (index == 0)
            {
                head = current.Next;

                if (head != null)
                {
                    head.Previous = null;
                }

                if (count == 1)
                {
                    tail = null;

                }
            }
        }

        // Remove all elements from the list.
        public void Clear()
        {
            head = null; // set the head to null
            tail = null; // set the tail to null
            count = 0; // set the count to zero
        }

    }

}
