namespace TestClass
{
    public class ListNode
    {
      public int val;
      public ListNode? next;
      public ListNode(int val = 0, ListNode? next = null)
      {
        this.val = val;
        this.next = next;
      }
    }

    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode first = null, second = null, third = null;
            if(head != null && head.next != null)
            {
                first = head;
                second = head.next;
                third = second.next;
            }
        }
    }

    public class Class1
    {

    }
}