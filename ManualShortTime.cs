using System;

namespace Times
{
    public class ManualShortTime : IShortTime
    {
        private float _value;
        public int Ticks => (int)(_value * TimeSpan.TicksPerSecond);

        public void Step(ShortTimeSpan dt)
        {
            _value += dt;
        }
    }
}