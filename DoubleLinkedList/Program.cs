using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleLinkedNode<T>:DoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }

        public DoubleLinkedNode(T value1)
        {
            Value = value1;
        }
    }

    public class DLinkedList<T> 
    {
        public DoubleLinkedNode<T> First { get; set; }
        public DoubleLinkedNode<T> Last { get; set; }
        int count;

        public DLinkedList()
        {
            count = 0;
        }

        public void AddFirst(T value)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(value);
            DoubleLinkedNode<T> temp = First;
            node.Next = temp;
            First = node;
            if (count == 0)
                Last = First;
            else
                temp.Prev = node;
            count++;
        }

        public void AddLast(T value)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(value);

            if (First == null)
                First = node;
            else
            {
                Last.Next = node;
                node.Prev = Last;
            }
            Last = node;
            count++;
        }

        public void Reverse()
        {
            DoubleLinkedNode<T> node = First;
            while (node != null)
            {
                DoubleLinkedNode<T> temp = node.Next;
                node.Next = node.Prev;
                node.Prev = temp;
                node = temp;
            }
            node = Last;
            Last = First;
            First = node;
        }

        public override string ToString()
        {
            string lst = "";
            DoubleLinkedNode<T> node = First;
            while (node != null)
            {
                lst += node.Value.ToString();
                lst += " ";
                node = node.Next;
            }
            return lst;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList<int> list = new DLinkedList<int>();
            list.AddFirst(2);
            list.AddLast(3);
            list.AddFirst(1);
            Console.WriteLine(list.ToString());
            list.Reverse();
            Console.WriteLine(list.ToString());
            Console.ReadKey();
        }
    }
}