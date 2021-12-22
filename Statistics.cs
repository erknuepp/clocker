namespace clocker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Statistics
    {
        public static TimeSpan Average(List<Lap> laps) 
        {
            return new TimeSpan((long)laps.Select(x => x.Elapsed.Ticks).Average());        
        }
    }
}