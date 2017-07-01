using System;

namespace RamilSample
{
    public delegate void DelSample();

    public class EventsSample
    {
        public event DelSample eventSample;

        public EventsSample()
        {
            eventSample = Run;
            eventSample += Run2;
        }

        public void Start()
        {
            if (eventSample != null) 
                eventSample();
        }

        private void Run()
        {
            Console.Write("Run!");
        }

        private void Run2()
        {
            Console.Write("Run2!");
        }
    }
}
