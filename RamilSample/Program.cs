using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RamilSample
{
    class Program
    {
        static void Main(string[] args)
        {
            EventsSample eS = new EventsSample();
            eS.Start();
            Thread.Sleep(1000*10);
            eS.Stop();
        }
    }
}
