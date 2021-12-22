namespace clocker
{
    using System.Threading;

    internal static class Utilities
    {
        public static void Sleep(int seconds)
        {
            Sleep(new System.TimeSpan(0, 0, seconds));
        }

        private static void Sleep(System.TimeSpan timeout)
        {
            Thread.Sleep(timeout);
        }
    }
}