using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplimintation
{
   public class BinaryTree
   {
       Node top;

       public BinaryTree()
       {
           top = null;
       }

       public BinaryTree(int data)
       {
            top = new Node(data);
       }

        public void Add(int data)
        {
            Add(ref top, data);
        }
        
        private void Add(ref Node n,int value)
        {

        }
        
        public void Print( ref string newstring)
        {

        }


   }
}
