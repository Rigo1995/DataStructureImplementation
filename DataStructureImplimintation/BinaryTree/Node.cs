using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplimintation
{
    public class Node
    {
        public Node leftCar;
        public int data;
        public Node rightCar;

        public Node(int data)
        {
            this.data = data;
            leftCar= null;
            rightCar = null;

        }


    }
}
