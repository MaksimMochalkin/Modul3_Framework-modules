using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class User
    {
        public void Reaction(object sender, TimerEndEventARG e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
