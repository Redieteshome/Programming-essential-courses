using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(StringChallenge("9:00am-10:00am")); // Output: 60
        Console.WriteLine(StringChallenge("1:00pm-11:00am")); // Output: 1320
    }

    static int StringChallenge(string str)
    {
        string[] times = str.Split('-');
        string startTime = times[0];
        string endTime = times[1];

        DateTime start = DateTime.Parse(startTime);
        DateTime end = DateTime.Parse(endTime);

        if (end < start)
        {
            end = end.AddDays(1);
        }

        TimeSpan duration = end - start;
        return (int)duration.TotalMinutes;
    }
}
