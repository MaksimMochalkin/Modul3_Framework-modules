using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;

namespace ConsoleApp2
{
    public class TimerEndEventARG
    {
        public int Time { get; }
        public string Message { get; }
        public DateTime TimerEndTime { get; }

        public TimerEndEventARG(DateTime timerEndTime, int time, string message)
        {
            TimerEndTime = timerEndTime;
            Time = time;
            Message = message;
        }
    }
}
