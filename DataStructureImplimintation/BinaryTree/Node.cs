using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplimintation
{
    public class Node
    {
        public Node left;
        public int data;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left= null;
            right = null;

        }


    }
}
