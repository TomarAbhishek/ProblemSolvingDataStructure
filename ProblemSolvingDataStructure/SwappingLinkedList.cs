using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    public class SwappingLinkedList
    {
        public static void Main(string[] args)
        {
            ListNode l6 = new ListNode(8);
            ListNode l5 = new ListNode(5, l6);
            ListNode l4 = new ListNode(4, l5);
            ListNode l3 = new ListNode(3, l4);
            ListNode l2 = new ListNode(2, l3);
            ListNode l1 = new ListNode(1, l2);

            ListNode n = SwappingLinkedList.SwapPairs(l1);
            //Console.WriteLine(n); 
            Console.ReadLine();

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("Hello");
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        //SwapNode 
        public static ListNode SwapNodes(ListNode head, int k)
        {
            var first = head;
            var prevFirst = head;
            for (int i = 0; i < k - 1; i++)
            {
                prevFirst = first;
                first = first.next;
            }

            var swapFirstNode = first;

            var second = head;
            var prevSecond = head;
            while (first.next != null)
            {
                prevSecond = second;
                second = second.next;
                first = first.next;
            }

            var temp1 = swapFirstNode;
            var temp2 = second.next;

            //swapping
            prevFirst.next = second;
            second.next = temp1.next;
            prevSecond.next = swapFirstNode;
            swapFirstNode.next = temp2;

            return head;
        }

        //Swapping value without change anything else;
        public static ListNode SwapNodesValue(ListNode head, int k)
        {
            var traverseNode = head;
            for(int i=0; i < k - 1; i++)
            {
                traverseNode = traverseNode.next;
            }
            var firstNode = traverseNode;
            var secondNode = head;
            while (traverseNode.next != null)
            {
                traverseNode = traverseNode.next;
                secondNode = secondNode.next;
            }

            var temp = secondNode.val;
            secondNode.val = firstNode.val;
            firstNode.val = temp;
            return head;
        }

        //PAIR SUM 
        //In a linked list of size n, where n is even, the ith node(0-indexed) of the linked list is known as the twin of the(n-1-i)th node, if 0 <= i <= (n / 2) - 1.
        //For example, if n = 4, then node 0 is the twin of node 3, and node 1 is the twin of node 2. These are the only nodes with twins for n = 4.
        public static int PairSum(ListNode head)
        {
            var pointer = head;
            int result = 0;

            List<int> values = new List<int>();
            values.Add(pointer.val);
            Console.WriteLine(pointer.val);
            while (pointer.next != null)
            {
                pointer = pointer.next;
                values.Add(pointer.val);
                Console.WriteLine(pointer.val);
            }

            for (int i = 0, j = values.Count() - 1; i <= (values.Count()) / 2; i++, j--)
            {
                result = Math.Max(result, (values[i] + values[j]));
            }

            return result;
        }

        public static ListNode SwapPairs(ListNode head)
        {
            var start = head;
            int count = 1;
            var prev = head;
            var second = head;
            while (start.next != null)
            {
                count++;
                prev = second;
                second = start.next;
                if (count % 2 == 0)
                {
                    var temp = second.val;
                    second.val = prev.val;
                    prev.val = temp;
                }
                start = start.next;
            }
            return head;
        }
    }
}
