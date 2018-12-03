namespace Adt
{
	public class MyLinkedList
	{
		private Node Head;
		private int count = 0;
		public int Count { get { return count; } set { count = value; } }

		public void Insert(object element)
		{
			Insert(element, 0);
		}

		public void Insert(object element, int index)
		{
			Node nodeToInsert = new Node(element);
			if (index.Equals(0))
			{
				nodeToInsert.Next = Head;
				Head = nodeToInsert;
			}
			else
			{
				Node nodeToInsertAfter = FindNodeAt(index - 1);
				nodeToInsert.Next = nodeToInsertAfter.Next;
				nodeToInsertAfter.Next = nodeToInsert;
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
			Count--;
		}

		public void Delete(int index)
		{
			Node nodeToDeletAfter = FindNodeAt(index - 1);
			nodeToDeletAfter.Next = nodeToDeletAfter.Next.Next;
			count--;
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
	}
}