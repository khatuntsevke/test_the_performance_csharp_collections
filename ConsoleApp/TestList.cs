using ConsoleApp;
using System.Collections.Generic;
using System.Text;

namespace MyApp
{
    class TestList
    {
        private List<int> _researchObject;
        
        public TestList()
        {
            _researchObject = new List<int>();
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
            foreach (var element in _researchObject)
            {
                if (element % 777 == 0)
                {
                    Console.WriteLine($"{element} делится 777 без остатка.");
                }
            }
        }

        public void FindAllElementsByConditionWithFastConsole()
        {
            foreach (var element in _researchObject)
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
            foreach (var element in _researchObject)
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
      

