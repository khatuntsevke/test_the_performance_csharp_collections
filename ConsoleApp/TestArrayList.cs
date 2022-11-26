using ConsoleApp;
using System.Collections;

namespace MyApp
{
    class TestArrayList
    {
        private ArrayList _researchObject;

        public TestArrayList()
        {
            _researchObject = new ArrayList();
        }

        public void InitAndFill()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _researchObject.Add(i);
            }
        }
        public void RandomItemAccess()
        {
            var randomEl = _researchObject[496763];
        }
        public void FindAllElementsByCondition()
        {
            foreach (int element in _researchObject)
            {
                if (element % 777 == 0)
                {
                    Console.WriteLine($"{element} делится 777 без остатка.");
                }
            }
        }

        public void FindAllElementsByConditionWithFastConsole()
        {
            foreach (int element in _researchObject)
            {
                if (element % 777 == 0)
                {
                    FastConsole.WriteLine($"{element} делится 777 без остатка.");
                    //Console.WriteLine($"{element} делится 777 без остатка.");
                }
            }
            FastConsole.Flush();
        }

        public void FindAllElementsByConditionWithAccumulationList()
        {
            var accumulationList = new List<int>();
            foreach (int element in _researchObject)
            {
                if (element % 777 == 0)
                {
                    // Console.WriteLine($"Элемент {element} делится 777 без остатка.");
                    accumulationList.Add(element);
                }
            }
            Console.WriteLine(string.Join(" делиться на 777 без остатка\n", accumulationList) + " делиться на 777 без остатка");
        }
    }
}
