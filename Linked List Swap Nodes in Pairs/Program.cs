using System;

namespace Linked_List_Swap_Nodes_in_Pairs
{
  class Program
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

    public ListNode SwapPairs(ListNode head)
    {
      ListNode dummy = new ListNode();
      ListNode anotherDummy = dummy;
      while (head != null && dummy != null && head.next != null)
      {
        dummy.next = Swap(head, head.next);
        head = head.next.next;
        dummy = dummy.next.next;
      }
      if (head != null && dummy != null) dummy.next = head;
      return anotherDummy.next;
    }

    ListNode Swap(ListNode l1, ListNode l2)
    {
      ListNode temp = new ListNode(l2.val);
      temp.next = new ListNode(l1.val);
      return temp;
    }

    public ListNode Swap(ListNode head)
    {
      ListNode dummy = new ListNode();
      dummy.next = head;
      ListNode current = dummy;
      while (current.next != null && current.next.next != null)
      {
        ListNode first = current.next;
        ListNode second = current.next.next;
        first.next = second.next;
        current.next = second;
        second.next = first;
        current = current.next.next;
      }

      return dummy.next;
    }

    static void Main(string[] args)
    {
      ListNode head = new ListNode(1);
      head.next = new ListNode(2);
      head.next.next = new ListNode(3);
      head.next.next.next = new ListNode(4);
      head.next.next.next.next = new ListNode(5);
      head.next.next.next.next.next = new ListNode(6);
      head.next.next.next.next.next.next = new ListNode(7);
      //head.next.next.next.next.next.next.next = new ListNode(8);
      Program p = new Program();
      ListNode node = p.Swap(head);
      while (node != null)
      {
        Console.WriteLine(node.val);
        node = node.next;
      }
    }
  }
}