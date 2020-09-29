using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }

        public int NumberOfLeafNodes()
        {
            //return 1 when leaf node is found
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            //recursively call NumOfLeafNodes returning 1 for each leaf found
            if (this.LeftNode != null)
            {
                leftLeaves = LeftNode.NumberOfLeafNodes();
            }
            if (this.RightNode != null)
            {
                rightLeaves = RightNode.NumberOfLeafNodes();
            }

            //add values together 
            return leftLeaves + rightLeaves;
        }

        public int Height()
        {
            //return 1 when leaf node is found
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int left = 0;
            int right = 0;

            //recursively go through each branch
            if (this.LeftNode != null)
                left = this.LeftNode.Height();
            if (this.RightNode != null)
                right = this.RightNode.Height();

            //return the greater height of the branch
            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }
            
        }
        public int countNonLeafNodes()
        {
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            //recursively call NumOfLeafNodes returning 1 for each leaf found
            if (this.LeftNode != null)
            {
                leftLeaves = LeftNode.countNonLeafNodes();
            }
            if (this.RightNode != null)
            {
                rightLeaves = RightNode.countNonLeafNodes();
            }

            //add values together 
            return 1 + leftLeaves + rightLeaves;
        }
    }
    }
    //if ((LeftNode == null &&
    //                             RightNode == null))
    //            return 0;
    //        return 1 + countNonLeafNodes(LeftNode) +
    //                   countNonLeafNodes(RightNode);

