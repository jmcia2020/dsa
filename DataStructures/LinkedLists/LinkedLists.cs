﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Head = new Node(value);
        }

        public bool Include(int valueToFind)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //TODO: homework
            return "NULL";
        }
    }
}
