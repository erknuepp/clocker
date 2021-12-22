namespace clocker
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {

            Lap lap = new Lap(new TimeSpan(0, 0, 0), new TimeSpan(0, 1, 0));
            Console.WriteLine(lap.Elapsed);
            Console.WriteLine(Formatter.FormatTime(lap.Elapsed));
            Console.WriteLine(Formatter.ShortFormatTime(lap.Elapsed));
        }
    }
}
