namespace clocker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    internal static class StopWatch
    {
        private static Stopwatch _stopwatch;
        private static List<Lap> _laps;
        private static State _state;

        static StopWatch()
        {
            _stopwatch = new Stopwatch();
            _laps = new List<Lap>();
            _state = State.Reset;
        }

        static void Start()
        {

            if(_state == State.Reset || _state == State.Stopped)
            {
                _stopwatch.Start();
                _state = State.Running;
            }
        }

        static void Stop()
        {
            if (_state == State.Running)
            {
                _stopwatch.Stop();
                _state = State.Stopped;
            }
        }

        static void Reset()
        {
            if (_state == State.Running || _state == State.Stopped)
            {
                _stopwatch.Reset();
                _state = State.Reset;
            }
        }

        static void Lap()
        {
            Lap lap;
            if (_laps.Count > 0)
            {
                lap = new Lap(_laps.Last().Start, Elapsed);
                
            }
            else
            {
                lap = new Lap(new TimeSpan(0), Elapsed);
            }
            _laps.Add(lap);
        }

        static List<Lap> GetLaps() { return _laps; }

        public static bool IsRunning => _stopwatch.IsRunning;
        public static TimeSpan Elapsed => _stopwatch.Elapsed;
    }
}
