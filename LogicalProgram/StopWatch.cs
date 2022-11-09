
namespace LogicalProblem

{
    public class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        public void Start()
        {
            int startHr = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            Console.WriteLine("Press s to Start");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("Press x for Exit");
                string stop = Console.ReadLine().ToLower();
                if (stop.Equals("x"))
                {
                    DateTime timeSpan1 = DateTime.Now;
                    int endHr = timeSpan1.Hour;
                    int endMin = timeSpan1.Minute;
                    int endSec = timeSpan1.Second;
                    int endMilllisec = timeSpan1.Millisecond;
                    Console.WriteLine("Hours is : " + (endHr - startHr) + "\t Minutes is :  " + (endMin - startMin) + " \t Second is : " + (endSec - startSec)
                            + " \t MilliSeconds : " + (endMilllisec - startMilliSec));
                }
            }
        }
    }
}