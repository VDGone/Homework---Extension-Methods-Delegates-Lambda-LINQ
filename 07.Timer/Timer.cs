namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate(int time);

    class Timer
    {
        //Using delegates write a class Timer that can execute certain method at each t seconds.

        static void Main(string[] args)
        {
            TimerDelegate timer = delegate(int t)
            {
                while (t > 0)
                {
                    t--;
                    Console.WriteLine("I have no idea what i'm doing! But I know what time is it: {0}", DateTime.Now);
                }
            };
            timer(50);
        }
    }
}
