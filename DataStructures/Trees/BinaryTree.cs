using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            return PreOrder(Root, result);
            return result;
        }

        private void PreOrder(Node node, List<int> result)
        {
            // Stretch Goal, use yield return instead
            //yield return works for IEnumerable<int>
            result.Add(node.Value);

            if (node.Left != null)
                PreOrder(node.Left, result);

            if (node.Right != null)
                PreOrder(node.Right, result);

        }
        //ToDo: PostOrder, InOrder
    }


    public class Node
    {
        //Stretch goal: make this generic

        public int Value { get; set; }

        public Node left { get; set; }
        public Node right { get; set; }
    }
    
}
