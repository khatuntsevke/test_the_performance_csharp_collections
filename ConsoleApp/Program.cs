using System.Collections.Generic;
using System.Xml.Linq;

namespace MyApp
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            var laboratory = new OtusMeasuringLaboratory();
            
            var testList = new TestList();             
            laboratory.MeasurePerformance("List, initialize", testList.InitAndFill);
            laboratory.MeasurePerformance("List, random access", testList.RandomItemAccess);
            laboratory.MeasurePerformance("List, search an element by condition", testList.FindAllElementsByCondition);
            laboratory.MeasurePerformance("List, search an element by condition with fast console", testList.FindAllElementsByConditionWithFastConsole);
            laboratory.MeasurePerformance("List, search an element by condition with accumulation list", testList.FindAllElementsByConditionWithAccumulationList);

            var testArrayList = new TestArrayList();
            laboratory.MeasurePerformance("ArrayList, initialize", testArrayList.InitAndFill);
            laboratory.MeasurePerformance("ArrayList, random access", testArrayList.RandomItemAccess);
            laboratory.MeasurePerformance("ArrayList, search an element by condition", testArrayList.FindAllElementsByCondition);
            laboratory.MeasurePerformance("ArrayList, search an element by condition with fast console", testArrayList.FindAllElementsByConditionWithFastConsole);
            laboratory.MeasurePerformance("ArrayList, search an element by condition with accumulation list", testArrayList.FindAllElementsByConditionWithAccumulationList);

            var testLinkedList = new TestLinkedList();
            laboratory.MeasurePerformance("LinkedList, initialize", testLinkedList.InitAndFill);
            laboratory.MeasurePerformance("LinkedList, random access", testLinkedList.RandomItemAccess);
            laboratory.MeasurePerformance("LinkedList, search an element by condition", testLinkedList.FindAllElementsByCondition);
            laboratory.MeasurePerformance("LinkedList, search an element by condition with fast console", testLinkedList.FindAllElementsByConditionWithFastConsole);
            laboratory.MeasurePerformance("LinkedList, search an element by condition with accumulation list", testLinkedList.FindAllElementsByConditionWithAccumulationList);

            laboratory.PrintLogs();
        }
    }
}

