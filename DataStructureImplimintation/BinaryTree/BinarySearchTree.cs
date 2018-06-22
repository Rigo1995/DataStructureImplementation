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
            if (top == null)
            {
                Node NewNode = new Node(data);
                top = NewNode;
                return;
            }
            Node currentnode = top;
            bool added = false;
            do
            {
                if (data < currentnode.data)
                {
                    if (currentnode.leftCar == null)
                    {
                        Node NewNode = new Node(data);
                        currentnode.leftCar = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.leftCar;
                    }
                }
                if (data >= currentnode.data)
                {
                    if (currentnode.rightCar == null)
                    {
                        Node newnode = new Node(data);
                        currentnode.rightCar = newnode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.rightCar;
                    }
                }


            } while (!added);

        }
        
        //private void Add(ref Node n,int value)
        //{

        //}
        
        //public void Print( ref string newstring)
        //{

        //}


   }
}
