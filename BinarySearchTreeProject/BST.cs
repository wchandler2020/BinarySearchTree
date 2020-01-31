using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BST
    {
        public Node root;

        public void Insert(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                while (true)
                {
                  
                    if (data < current.data)
                    {
                        if (current.LeftNode == null)
                        {
                            //current.LeftNode = current;
                            current = node;
                            break;
                        }
                        else
                        {
                            current = current.LeftNode;
                        }

                    }
                    else
                    {
                        if (current.RightNode == null)
                        {
                            //root.RightNode = current;
                            current = node;
                            break;
                        }
                        else
                        {
                            current = current.RightNode;
                        }
                    }
                }  
            }
        }

        public Boolean Search(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                return false;
            }else
            {
                while (true)
                {
                    Node current = root;
                    if (data < current.data)
                    {
                        if (current.LeftNode == null)
                        {

                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (current.RightNode == null)
                        {

                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
