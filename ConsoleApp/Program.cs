using System;
using System.Collections;

namespace MyApp
{

    public static class MyArrayListExtension
    {
        public static void Append(this ArrayList arrayList, object value)
        {
            arrayList.Add(value);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new PerformanceTester< List<int> >();

            var l = new List<int>();
            var al = new ArrayList();
            var ll = new LinkedList<int>();

            ll.Append(0);
            l.Append(0);
            al.Append(0);

            

        }
    }
}

