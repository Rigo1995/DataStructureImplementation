using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplimintation
{
    public class Node
    {
        public Node leftMan;
        public int data;
        public Node rightWoman;

        public Node(int data)
        {
            this.data = data;
            leftMan= null;
            rightWoman = null;

        }


    }
}
