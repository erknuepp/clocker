namespace clocker
{
    using System;

    internal static class Formatter
    {
        public static string FormatTime(TimeSpan o)
        {
            var hours = o.Hours;
            var minutes = o.Minutes;
            var seconds = o.Seconds;
            var milliseconds = o.Milliseconds;
            return $"Hour(s) {hours} Minute(s) {minutes} Second(s) {seconds} Millisecond(s) {milliseconds}";
        }

        public static string ShortFormatTime(TimeSpan o)
        {
            var hours = o.Hours;
            var minutes = o.Minutes;
            var seconds = o.Seconds;
            var milliseconds = o.Milliseconds;
            return $"{hours} : {minutes} : {seconds} : {milliseconds}";
        }
    }
}
