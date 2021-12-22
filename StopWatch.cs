namespace clocker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    internal class StopWatch
    {
        private Stopwatch _stopwatch;
        private List<Lap> _laps;
        private State _state;

        public StopWatch()
        {
            _stopwatch = new Stopwatch();
            _laps = new List<Lap>();
            _state = State.Reset;
        }

        public void Start()
        {

            if (_state == State.Reset || _state == State.Stopped)
            {
                _stopwatch.Start();
                _state = State.Running;
            }
        }

        public void Stop()
        {
            if (_state == State.Running)
            {
                _stopwatch.Stop();
                Lap();
                _state = State.Stopped;
            }
        }

        public void Reset()
        {
            if (_state == State.Running || _state == State.Stopped)
            {
                _stopwatch.Reset();
                _state = State.Reset;
            }
        }

        public void Lap()
        {
            Lap lap;
            if (_laps.Count > 0)
            {
                lap = new Lap(_laps.Last().End, Elapsed);
            }
            else
            {
                lap = new Lap(new TimeSpan(0), Elapsed);
            }
            _laps.Add(lap);
        }

        public List<Lap> GetLaps() { return _laps; }

        public bool IsRunning => _stopwatch.IsRunning;
        public TimeSpan Elapsed => _stopwatch.Elapsed;
    }
}
