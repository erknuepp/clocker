namespace clocker
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch sw = new StopWatch();
            sw.Start();
            Utilities.Sleep(2);
            sw.Lap();
            Utilities.Sleep(2);
            sw.Lap();
            Utilities.Sleep(2);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            foreach (var lap in sw.GetLaps())
            {
                Console.WriteLine(lap);
            }
        }
    }
}