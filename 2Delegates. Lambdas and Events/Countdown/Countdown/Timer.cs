using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    public class Timer
    {
        /// <summary>
        /// The event occurs after the end of time
        /// </summary>
        public EventHandler<TimerEndEventARG> TimerEnd = delegate { };

        /// <summary>
        /// Notifies subscrube
        /// </summary>
        /// <param name="time">milliseconds</param>
        public void TimerUse(int time)
        {
            if (time < 0)
            {
                throw new ArgumentException(nameof(time), "Time must be greater than 0");
            }
            Thread.Sleep(time);
            OnTimerEnd(new TimerEndEventARG(DateTime.Now, time, "Hello"));
        }

        public void OnTimerEnd(TimerEndEventARG e)
        {
            TimerEnd?.Invoke(this, e);
        }
    }
}
