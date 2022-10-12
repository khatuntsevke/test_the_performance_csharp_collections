namespace MyApp
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            var laboratory = new OtusMeasuringLaboratory();
            
            var testList = new TestList();
            Action testListInit = testList.InitAndFill;
            Action testListRAccess = testList.RandomItemAccess;
            Action testListFindEl = testList.FindAllElementsByCondition;
             
            laboratory.MeasurePerformance("List initialize", testListInit);
            laboratory.MeasurePerformance("List random access", testListRAccess);
            laboratory.MeasurePerformance("List search an element by condition", testListFindEl);

            var testArrayList = new TestArrayList();
            Action testArrayListInit = testArrayList.InitAndFill;
            Action testArrayListRAccess = testArrayList.RandomItemAccess;
            Action testArrayListFindEl = testArrayList.FindAllElementsByCondition;

            laboratory.MeasurePerformance("ArrayList initialize", testArrayListInit);
            laboratory.MeasurePerformance("ArrayList random access", testArrayListRAccess);
            laboratory.MeasurePerformance("ArrayList search an element by condition", testArrayListFindEl);

            var testLinkedList = new TestArrayList();
            Action testLinkedListInit = testLinkedList.InitAndFill;
            Action testLinkedListRAccess = testLinkedList.RandomItemAccess;
            Action testLinkedListFindEl = testLinkedList.FindAllElementsByCondition;

            laboratory.MeasurePerformance("LinkedList initialization", testLinkedListInit);
            laboratory.MeasurePerformance("LinkedList random access", testLinkedListRAccess);
            laboratory.MeasurePerformance("LinkedList search an element by condition", testLinkedListFindEl);

            laboratory.PrintLogs();
        }
    }
}

