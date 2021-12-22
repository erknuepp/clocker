namespace clocker
{
    using System;

    internal struct Lap
    {
        public TimeSpan Start { get; init; }
        public TimeSpan End { get; init; }
        public TimeSpan Elapsed => End - Start;

        public Lap(TimeSpan start, TimeSpan end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"Start: {Start} End: {End} Elapsed: {Elapsed}";
        }
    }
}