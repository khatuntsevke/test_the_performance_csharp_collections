using System.Diagnostics;
public class OtusMeasuringLaboratory
{
    private Stopwatch _stopwatch;
    private List<Tuple<string, string>> logs;
    
    public OtusMeasuringLaboratory()
    {
        _stopwatch = new Stopwatch();
        logs = new List<Tuple<string, string>>();
    }
    public void MeasurePerformance(string testName, Action test)
    {
        _stopwatch.Start();
        
        test();
        
        _stopwatch.Stop();
        
        TimeSpan ts = _stopwatch.Elapsed;        
        string elapsedTime = String.Format("{0:00} сек:{1:00} милисек",
            ts.Seconds, ts.Milliseconds);
        Console.WriteLine("Время работы " + elapsedTime);

        logs.Add(Tuple.Create(testName, elapsedTime));
    }

    public void PrintLogs()
    {
        Console.WriteLine("\nЖурнал логов измерения времени работы тестов:");

        int i = 1;
        foreach (var log in logs)
        {
            Console.WriteLine($"Измерение {i} {log}");
            i++;
        }
    }
}
