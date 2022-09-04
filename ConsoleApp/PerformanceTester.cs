using System;
using System.Diagnostics;

public class PerformanceTest
{
    PerformanceTest()
    { }
}

public class TestFilling(): public PeformanceTest
{

}


public class PerformanceTester<T> where T : new()
{
    private Stopwatch _stopwatch;
	public PerformanceTester()
	{
        _stopwatch = new Stopwatch();

        var testCollection = new T();

        Test();

    }

    void TestFilling ()
    {
        _stopwatch.Start();

        _stopwatch.Stop();
        TimeSpan ts = _stopwatch.Elapsed;        
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }


}
