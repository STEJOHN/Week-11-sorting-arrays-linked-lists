namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }
        public int count = 0;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0)
            {
                return -1;
            }
            if (index > count - 1)
            {
                return -1;
            }
            ListNode curr = Head;
            while (index != 0 || curr == null)
            {
                curr = curr.next;
                index--;
            }

            return curr.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode node = new(val);
            if (Head != null)
            {
                node.next = Head;
            }
            Head = node;
            count++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            ListNode curr = Head;
            if (Head == null)
            {
                AddAtHead(val);
                return;
            }

            Head.next = new ListNode(val);
            Head = Head.next;
            
            count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > count)
            {
                return;
            }
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            if (index == count)
            {
                AddAtTail(val);
                return;
            }
            ListNode node = new(val);
            ListNode curr = Head;
            while (index != 1)
            {
                curr = curr.next;
                index--;
            }
            node.next = curr.next;
            curr.next = node;
            count++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index > count - 1)
            {
                return;
            }
            ListNode curr = Head;
            if (index == 0)
            {
                Head = Head.next;
                count--;
                return;
            }
            while (index != 1)
            {
                curr = curr.next;
                index--;
            }
            ListNode del = curr.next;
            curr.next = del.next;
            del.next = null;
            count--;
        }
    }
}

    