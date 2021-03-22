using System;

namespace NewStopwatch
{
    class Stopwatch
    {
        private static bool _timerOn = false;
        private static DateTime _startTime;
        private static DateTime _stopTime;

        public static void Start()
        {
            if (_timerOn == true)
            {
                throw new InvalidOperationException("Stopwatch is already running - type 'stop'.");
            }
            _timerOn = true;
            _startTime = DateTime.Now;
        }

        public static TimeSpan Stop()
        {
            if (_timerOn == false)
            {
                throw new InvalidOperationException("Stopwatch is not yet running - type 'start'.");
            }
            _timerOn = false;
            _stopTime = DateTime.Now;

            return _stopTime - _startTime;
        }
    }
}
