using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node HEAD { get; set; }

        public void Insert (int value)
        {
            HEAD = new Node(value);
        }

        public bool Include(int vallueToFind)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
            {
                //TODO: homework
                return "NULL";
            }
        }
    }
}
