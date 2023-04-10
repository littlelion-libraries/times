using System;

namespace Times
{
    public readonly struct ShortTimeSpan
    {
        public ShortTimeSpan(float seconds)
        {
            Seconds = seconds;
        }

        public float Seconds { get; }

        public static DateTime operator +(DateTime a, ShortTimeSpan b)
        {
            return a + TimeSpan.FromSeconds(b.Seconds);
        }

        public static float operator +(float a, ShortTimeSpan b)
        {
            return a + b.Seconds;
        }

        public static float operator +(ShortTimeSpan a, float b)
        {
            return a.Seconds + b;
        }

        public static ShortTimeSpan operator -(ShortTimeSpan a, ShortTimeSpan b)
        {
            return new ShortTimeSpan(a.Seconds - b.Seconds);
        }

        public static float operator *(float a, ShortTimeSpan b)
        {
            return a * b.Seconds;
        }

        public static float operator *(ShortTimeSpan a, float b)
        {
            return a.Seconds * b;
        }

        public static bool operator >(ShortTimeSpan a, float b)
        {
            return a.Seconds > 0;
        }

        public static bool operator <(ShortTimeSpan a, float b)
        {
            return a.Seconds < 0;
        }

        public static implicit operator float(ShortTimeSpan value)
        {
            return value.Seconds;
        }

        public static implicit operator ShortTimeSpan(float value)
        {
            return new ShortTimeSpan(value);
        }
    }
}