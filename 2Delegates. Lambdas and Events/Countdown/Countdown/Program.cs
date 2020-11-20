using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();


            User user1 = new User();
            User user2 = new User();

            timer.TimerEnd += user1.Reaction;
            timer.TimerEnd += user2.Reaction;

            timer.TimerUse(1000);

            timer.TimerEnd -= user2.Reaction;
            timer.TimerUse(1000);
            Console.ReadKey();


        }
    }
}
