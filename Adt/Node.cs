﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
	class Node
	{
		private Node next;
		private Node prev;
		private object data;
		public Node Next { get { return next; } set { next = value; } }
		public Node Prev { get { return prev; } set { prev = value; } }
		public object Data { get { return data; } set { data = value; } }
		public Node(object data)
		{
			Data = data;
		}
	}
}
