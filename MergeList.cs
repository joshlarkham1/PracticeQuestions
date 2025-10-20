using System;

namespace PracticeQuestions
{
    public class MergeList : IRunnable
    {
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

        public void Run()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            ListNode merged = MergeTwoLists(list1, list2);

            while (merged != null)
            {
                Console.Write(merged.val + " ");
                merged = merged.next;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = (list1 != null) ? list1 : list2;

            return dummy.next;
        }
    }
}
