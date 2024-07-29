using System;

namespace SinglyLinkedList
{
    using System;
    public partial class LinkedList
    {
        public class Node
        {
            internal int data; //Data to store (could be int,string,object etc)
            internal Node nextElement; //Pointer to next element

            public Node()
            {
                //Constructor to initialize nextElement of newlyCreated Node
                nextElement = null;
            }
        };
        Node head;

        public LinkedList()
        {
            head = null;
        }
        public Node GetHead()
        {
            return head;
        }
        bool IsEmpty()
        {
            if (head == null) //Check whether the head points to null
                return true;
            else
                return false;
        }
        public bool PrintList()
        {
            if (IsEmpty())
            {
                Console.Write("List is Empty!");
                return false;
            }
            Node temp = head;
            Console.Write("List : ");

            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.nextElement;
            }
            Console.WriteLine("null ");
            return true;
        }
        public void InsertAtHead(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.nextElement = head; //Linking newNode to head's nextNode
            head = newNode;
            Console.Write(value + " Inserted!");
        }
        public string Elements()
        {
            string elementsList = "";
            Node start = head;

            while (start != null)
            {
                elementsList += start.data.ToString();
                elementsList += "->";
                start = start.nextElement;
            }
            elementsList += "null";
            return elementsList;
        }
        public void InsertAtTail(int value)
        {
            // Enter your code here
            if (IsEmpty())
            {
                InsertAtHead(value);
            }
            else
            {
                Node newNode = new Node();
                Node last = head;
                while (last.nextElement != null)
                {
                    last = last.nextElement;
                }
                newNode.data = value;
                newNode.nextElement = null;
                last.nextElement = newNode;

            }
        }
    }
}
