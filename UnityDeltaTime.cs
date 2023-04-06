using UnityEngine;

namespace Times
{
    public class UnityDeltaTime : IDeltaTime
    {
        public ShortTimeSpan Value => new(Time.deltaTime);
    }
}