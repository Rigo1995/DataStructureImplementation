using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplimintation
{
    public class BinaryTree
    {
        Node current;
        Node root;
        public List<string> results = new List<string>();

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(int data)
        {
            root = new Node(data);
        }


        public void Search()
        { try 
            {
                bool search = searchTree(root, int.Parse(userImput("enter a  number to search")));
                if (search == false) 
                {
                    userImput(" not found");
                }
                else
                {
                    userImput("found it! at " + string.Join(", ", results));
                }
            }
            catch (FormatException e)
            {
                userImput(e.Message + "this is not a number");
            }
        }

        public string userImput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public bool searchTree(Node _current,int number)
        {
            current = _current;
            if (current == null)
            {
                return false;
            }
            else if (number > current.data)
            {
                results.Add("left");
                return searchTree(current.left, number);
            }
            else if (number < current.data)
            {
                results.Add("right");
                return searchTree(current.right, number);
            }
            else if (number == current.data)
            {
                return true;
            }
             else return false;
        }

        public void Add(int data)
        {
            if (root == null)
            {
                Node NewNode = new Node(data);
                root = NewNode;
                return;
            }
            Node currentnode = root;
            bool added = false;
            do
            {
                if (data < currentnode.data)
                {
                    if (currentnode.left == null)
                    {
                        Node NewNode = new Node(data);
                        currentnode.left = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.left;
                    }
                }
                if (data >= currentnode.data)
                {
                    if (currentnode.right == null)
                    {
                        Node newnode = new Node(data);
                        currentnode.right = newnode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.right;
                    }
                }
            } while (!added);
        }
    }
}
