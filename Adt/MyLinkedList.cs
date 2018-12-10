using System;

namespace Adt
{
	public class MyLinkedList
	{
		private Node Head;
		private Node Tail;
		private int count = 0;
		public int Count { get { return count; } set { count = value; } }

		public void Insert(object element)
		{
			Node nodeToInsert = new Node(element);
			if (Count.Equals(0))
				Head = nodeToInsert;
			else
			{
				nodeToInsert.Prev = Tail;
				Tail.Next = nodeToInsert;
			}
			Tail = nodeToInsert;
			count++;
		}

		public void Insert(object element, int index)
		{
			Node nodeToInsert = new Node(element);
			if (index.Equals(0))
			{
				nodeToInsert.Next = Head;
				Head.Prev = nodeToInsert;
				Head = nodeToInsert;
			}
			else
			{
				Node nodeToInsertAfter = FindNodeAt(index - 1);
				nodeToInsert.Next = nodeToInsertAfter.Next;
				if (!index.Equals(Count))
					nodeToInsertAfter.Next.Prev = nodeToInsert;
				nodeToInsertAfter.Next = nodeToInsert;
				nodeToInsert.Prev = nodeToInsertAfter;
			}
			Count++;
		}

		private Node FindNodeAt(int index)
		{
			Node node = Head;
			for (int i = 0; i < index; i++)
			{
				node = node.Next;
			}
			return node;
		}

		public void Delete()
		{
			Head = Head.Next;
			Head.Prev.Next = null;
			Head.Prev = null;
			Count--;
		}

		public void Delete(int index)
		{
			if (index.Equals(0))
				Delete();
			else
			{
				Node nodeToDelete = FindNodeAt(index);
				nodeToDelete.Prev.Next = nodeToDelete.Next;
				if (!index.Equals(Count - 1))
					nodeToDelete.Next.Prev = nodeToDelete.Prev;
				nodeToDelete.Next = null;
				nodeToDelete.Prev = null;
				count--;
			}
		}

		public object ItemAt(int index)
		{
			return FindNodeAt(index).Data;
		}

		public override string ToString()
		{
			string str = "";
			Node node = Head;
			while (node != null)
			{
				str += node.Data.ToString() + '\n';
				node = node.Next;
			}
			return str;
		}

		public void Rervers()
		{
			Node temp = Head;
			do
			{
				Node tempNode = temp.Next;
				temp.Next = temp.Prev;
				temp.Prev = tempNode;
				temp = temp.Prev;
			} while (temp != null);
			temp = Head;
			Head = Tail;
			Tail = temp;
		}

		public void Swap(int v)
		{
			Node temp1 = FindNodeAt(v);
			Node temp2 = temp1.Next;
			temp1.Next = temp2.Next;
			temp2.Prev = temp1.Prev;
			temp1.Prev = temp2;
			temp2.Next = temp1;
			if (!v.Equals(0))
				temp2.Prev.Next = temp2;
			if (!v.Equals(count-2))
				temp1.Next.Prev = temp1;
		}

		public string FremTilbage()
		{
			Node temp = Tail.Prev;
			string str = ToString();
			while (temp != null)
			{
				str += temp.Data.ToString() + '\n';
				temp = temp.Prev;
			}
			return str;
		}
	}
}