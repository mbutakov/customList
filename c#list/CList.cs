using System;

namespace ConsoleApp2
{
    class CList<T>
    {
        public T value;
        public int size
        {
            set
            {
                int i = 0;
                ListElement<T> Head = head;
                while (Head != null)
                {
                    i++;
                    Head = Head.next;
                }
                size = i;
            }
            get
            {
                int i = 0;
                ListElement<T> Head = head;
                while (Head != null)
                {
                    i++;
                    Head = Head.next;
                }
                return i;
            }
        }
        private ListElement<T> head;
        private ListElement<T> prev;
        private ListElement<T> list;
        private static ListElement<T> delEl;

        public void addElement(T number)
        {
            ListElement<T> l = new ListElement<T>(number);
            if (list != null)
            {
                GetLast().next = l;
                GetLast().prev = prev;
                prev = GetLast();
                return;
            }
            list = l;
            head = list;
            prev = list;
        }

        public void PushFront(T number)
        {
            ListElement<T> listE = new ListElement<T>(number);
            listE.next = head;
            head.prev = listE;
            head = listE;
        }

        public ListElement<T> PopFront()
        {
            GetLast().prev.next = null;
            delEl = GetLast();
            return delEl;
        }

        public ListElement<T> PopBack()
        {
            delEl = head;
            head.next.prev = null;
            head = head.next;
            return delEl;
        }

        public ListElement<T> Remove(int index)
        {
            if (index > size || index < 0)
            {
                throw new Exception("index > size or index < 0");
            }
            ListElement<T> current = head;
            ListElement<T> currentT = head;
            int i = 0;
            for (int j = 0; j < size; j++)
            {
                if (j == index)
                {
                    delEl = currentT;
                }
                currentT = currentT.next;
            }
            if (index != 0 && index <= size - 2)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == index)
                    {
                        current.prev.next = current.next;
                        current.next.prev = current.prev.next;
                    }
                    current = current.next;
                }
            }
            else if (index == 0 && index != size - 1)
            {
                current.next.prev = null;
                head = current.next;
            }
            else if (index != 0 && index >= size - 1)
            {
                if (GetLast() != null && GetLast().prev != null)
                {
                    GetLast().prev.next = null;
                }
                else
                {
                    GetLast().next = null;
                }
            }
            return delEl;
        }

        public void InsertBefore(int index, T number)
        {
            if (index > size || index < 0)
            {
                throw new Exception("index > size or index < 0");
            }
            ListElement<T> current = head;
            int i = 0;
            ListElement<T> e = new ListElement<T>(number);
            while (current.next != null && index <= size && index != 0)
            {
                if (i == index-1)
                {
                    e.prev = current;
                    e.next = current.next;
                    current.next = e;
                }
                current = current.next;
                i++;
            }
            if(index == 0)
            {
                current.prev = e;
                e.next = current;
                head = e;
            }
            if (current.next == null && index == size)
            {
               current.next = e;
            }

        }
        public void InsertAfter(int index, T number)
        {
            if (index > size - 1 || index < 0)
            {
                throw new Exception("index > size or index < 0");
            }
            ListElement<T> current = head;
            int i = 0;
            ListElement<T> e = new ListElement<T>(number);
            while (current.next != null && index != size)
            {
                if (i == index)
                {
                    e.prev = current;
                    e.next = current.next;
                    current.next = e;
                }
                current = current.next;
                i++;
            }
            if(current.next == null && index == size-1)
            {
                current.next = e;
                e.prev = current;
            }

        }

        public void InsertBefore(int index, ListElement<T> e)
        {
            ListElement<T> current = head;
            ListElement<T> TempCurrent;
            int i = 0;
            while (current.next != null)
            {
                if (i == index)
                {
                    e.prev = current;
                    e.next = current.next;
                    current.next = e;
                }
                current = current.next;
                i++;
            }
        }

        public ListElement<T> GetLast()
        {
            ListElement<T> current = list;
            while (current.next != null)
            {
                current = current.next;
            }
            return current;

        }

        public void Print()
        {
            ListElement<T> Head = head;
            while (Head != null)
            {
                Console.WriteLine(Head.value);
                Head = Head.next;
            }
            Console.WriteLine();
        }
    }
}
