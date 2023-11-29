using System;
using System.Runtime.InteropServices;

namespace Day4
{
    //var s = DateTime.Now;
    //Console.WriteLine(s.ToString());
    //        var start = DateTime.Now;
    //Console.WriteLine(start.ToString("T"));
    //        Thread.Sleep(2000);
    //        var stop = DateTime.Now;
    //Console.WriteLine(stop.ToString("T"));

    //        Console.WriteLine(stop-start);
    
    public class StopWatch {


       public DateTime start { get; set; }
      public DateTime stop { get; set; }   


        public void Start() {
            var start = DateTime.Now;
            Console.WriteLine(start.ToString("T"));

        }
        public void Stop() { 
        var stop = DateTime.Now;
            Console.WriteLine(stop.ToString("T"));
            Console.WriteLine((stop-start));
        }  
    }
}
