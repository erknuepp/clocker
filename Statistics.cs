namespace clocker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class Statistics
    {
        static TimeSpan Average(List<Lap> laps) 
        {
            var tickses = laps.Select(x => x.Elapsed.Ticks);
            var average = tickses.Average();
            return new TimeSpan((long)average);        
        }
    }
}
