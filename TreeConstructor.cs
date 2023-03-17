using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class TreeConstructor_
    { 

        public static string TreeConstructor(string[] strArr)
        {
            bool result = false;

            List<Node> nodeList = new List<Node>();

            HashSet<int> visited = new HashSet<int>();

            //Form the nodes
            foreach (string str in strArr)
            {
                List<string> values = str.Substring(1, str.Length - 2).Split(',').ToList();

                Node? child = nodeList.Find(x => x.value == Int32.Parse(values[0]));
                 
                if(child == null)
                {
                    child = new Node();
                    child.value = Int32.Parse(values[0]);
                    visited.Add(child.value);
                    nodeList.Add(child);
                }
                 

                //check if parent exists

                Node? parent = nodeList.Find(x => x.value == Int32.Parse(values[1]) );

                if(parent == null )
                {
                    Node parentNode = new Node();
                    parentNode.value = Int32.Parse(values[1]);
                    nodeList.Add(parentNode); 
                    visited.Add(Int32.Parse(values[1]));
                    child.parent= parentNode;
                }
                else 
                {
                    child.parent = parent;
                } 

            }

            result = IsValidBinaryTree(nodeList);

            return result.ToString();

        }

        public static bool IsValidBinaryTree(List<Node> nodeList)
        { 
            //check if only one node with no parent exists.

            int noParentCount = nodeList.Where( x => x.parent == null).Count();

            if(noParentCount != 1) 
            {
                return false;
            }

            //check if a parent has more than 2 children

            foreach( Node node in nodeList ) { 
                    int count =  nodeList.Where( x => x.parent != null && x.parent.value == node.value).Count();

                if(count > 2) 
                    return false;
            }

   

            return true;
        }


        public void Run()
        {
            string[] strArr = { "(1,2)", "(2,4)", "(7,2)" };

            TreeConstructor(strArr);
        }


    }

    public  class Node
    {
        public int value;
        public Node? parent;

    }
}
