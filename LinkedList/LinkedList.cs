using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;
        //UC1
        //Add method to insert into linkedlist
        internal void Add(int data)
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
        //UC2
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        //UC3
        //Append the LinkedList
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
        //UC4
        //Insert 30 elements in middle LinkedList
        public void InsertAtGivenPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        //UC5
        //Delete first elements in LinkedList
        public Node Pop()
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty: ");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        //UC6
        //Delete last elements in LinkedList
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return null;
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                Node removeNode = n.next;
                n.next = null;
                return removeNode;
            }
        }
        //UC7
        // Search LinkedList
        public int Search(int data)
        {
            int count = 1;
            Node temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        //UC8
        //Ability to insert 40 after 30 in LinkedList
        public void InsertNodeAfterParticularNode(int data, int dataToSearch)
        {
            int position = Search(dataToSearch);
            if (position == 0)
            {
                Console.WriteLine("No such elements found");
                return;
            }
            Node node = new Node(data);
            Node temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        //UC9
        //Ability to delete 40 from the LinkedList
        internal void DeleteAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
        internal void size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkedList is :" + " " + count);
        }
        //UC10
        //create Ordered Linked List in ascending order of data entered
        public void AscendingOrderSort(int data)
        {
            Node node = new Node(data);
            Node temp;
            if (head == null || head.data > node.data)
            {
                node.next = head;
                head = node;
            }
            else
            {
                temp = head;
                while (temp.next != null && temp.next.data < node.data)
                {
                    temp = temp.next;
                    node.next = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Data inserted " + node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}