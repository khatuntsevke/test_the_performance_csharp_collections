using System;
using System.Collections;

namespace MyApp
{
    class TestLinkedList
    {
        private LinkedList<int> _researchObject;

        public TestLinkedList()
        {
            _researchObject = new LinkedList<int>();
        }

        public void InitAndFill()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _researchObject.AddLast(i);
            }
        }
        public void RandomItemAccess()
        {
            var randomEl = _researchObject.ElementAt<int>(496763);
        }
        public void FindAllElementsByCondition()
        {
            foreach (var element in _researchObject)
            {
                if (element % 777 == 0)
                {
                    Console.WriteLine($"Элемент {element} делится 777 без остатка.");
                }
            }
        }
    }
}
