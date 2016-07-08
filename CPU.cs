using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace VLSSharp
{
    public class CPU
    {
        public static Thread th;


        public static void th_cpu()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            float useless = cpuCounter.NextValue();
            System.Threading.Thread.Sleep(100);
            float cpuval = cpuCounter.NextValue();

            Console.Out.WriteLine(cpuval);

        }
    }
}
