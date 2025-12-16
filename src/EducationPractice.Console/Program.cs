public class Program
{
    public static void Main(string[] args)
    {
        var counter = new Counter();
        counter.OnNumIncreased += (message) => Console.WriteLine(message);
        counter.OnGoalAchieved += (message) => Console.WriteLine(message);
        counter.OnCounterReset += (message) => Console.WriteLine(message);
        counter.OnNumDecreased += (message) => Console.WriteLine(message);
        counter.OnGoalLost += (message) => Console.WriteLine(message);

        counter.Start();
    }
}
