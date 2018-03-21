using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.ViewModels
{
    public static class LinkedListViewModel
    {

        public static LinkedList<int> InsertItemInSortedList(LinkedList<int> list, LinkedListNode<int> item)
        {

            LinkedListNode<int> current = list.First;
            bool last = true;
            while (current != null)
            {
                if (item.Value <= current.Value)
                {
                    list.AddBefore(current, item);
                    last = false;
                    break;
                }
                current = current.Next;
            }
            if (last) list.AddLast(item);
            return list;
        }


        public static LinkedList<int> RemoveDuplicatesFromSortedList(LinkedList<int> list)
        {

            LinkedListNode<int> current = list.First;
            LinkedListNode<int> next = current.Next;

            if (current == null) return new LinkedList<int>();

            while (current != null && current.Next != null)
            {
                if (current.Value == next.Value) list.Remove(current);
                current = next;
                next = next.Next;
            }

            return list;
        }



    }
}
