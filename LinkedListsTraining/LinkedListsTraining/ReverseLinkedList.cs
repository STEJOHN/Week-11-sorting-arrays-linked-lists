using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.ReverseLinkedList
{
    public class Solution
    {
        public static ListNode ReverseList(ListNode Head)
        {
            if (Head == null) return Head;
            else
            {
                MyLinkedList reverseList = new();
                ListNode current = Head;

                reverseList.AddAtHead(current.val);

                while (current.next != null)
                {
                    current = current.next;
                    reverseList.AddAtHead(current.val);

                }

                return reverseList.Head;
            }
        }
    }
}
