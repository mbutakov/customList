  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ListElement<T>
    {
        public T value;
        public ListElement<T> next;
        public ListElement<T> prev;
        public ListElement(T value)
        {

            this.value = value;
        }
    }
}