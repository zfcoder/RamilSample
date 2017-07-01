using System;
using System.Threading;

namespace RamilSample
{
    public delegate void DelSample();

    public class EventsSample
    {
        public event DelSample eventSample;
        private bool stop = false;
        private Thread thread1, thread2;

        public EventsSample()
        {
            thread1 = new Thread(Run);
            thread2 = new Thread(Run2);
        }

        public void Stop()
        {
            Console.WriteLine("Потоки закрыты.");
            stop = true;
        }

        public void Start()
        {
            thread1.Start();
            thread2.Start();
        }

        private void Run()
        {
            while (true)
            {
                if (stop) 
                    return;
                Console.Write("Run!");
                Thread.Sleep(1500);
            }
        }

        private void Run2()
        {
            while (true)
            {
                if (stop) 
                    return;
                Console.Write("Run2!");
                Thread.Sleep(2000);
            }
        }
    }
}
