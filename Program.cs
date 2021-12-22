namespace clocker
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch sw = new StopWatch();
            
            sw.Start();
            for (int i = 0; i < 10; i++)
            {
                Utilities.Sleep(1);
                sw.Lap();
            }            
            sw.Stop();

            foreach (var lap in sw.GetLaps())
            {
                Console.WriteLine(lap);
            }

            Console.WriteLine(sw.Elapsed);
            Console.WriteLine(Statistics.Average(sw.GetLaps()));
        }
    }
}