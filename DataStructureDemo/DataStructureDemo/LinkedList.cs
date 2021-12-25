using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    public class LinkedList
    {
        internal Node head;

        internal void add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine(" Invalid Postion");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position---- != 0)
                {
                    if (position == 1)
                    {
                        Node Node = new Node(data);
                        Node.next = this.head.next;
                        head.next = Node;
                        break;
                    }
                    head = head.next;
                }
            }
            if (position != 1)
            {
                Console.WriteLine(" position is out of range ");
            }
            Console.WriteLine(" inserted value " + head);
        }     return head;
    }
    internal Node RemoveFirstNode()
    {
        if (this.head == null)
        {
            return null;
        }
        this.head = this.head.next;
        return this.head;
    }
    internal Node RemoveLastNode()
    {
        if (head == null)
        {
            return null;
        }
        if (head.next == null)
        {
            return null;
        }
        Node NewNode = head;
        while (NewNode.next.next != null)
        {
            NewNode = NewNode.next;
        }
        NewNode.next = null;
        return head;
    }

}

