using System;

namespace StopWatch
{

    public class StopWatch {

        DateTime start = DateTime.Now;
        DateTime stop = DateTime.Now;


        public void Start()
        {
            var start = DateTime.Now;
            Console.WriteLine(start.ToString("T"));

        }
        public void Stop()
        {
            var stop = DateTime.Now;
            Console.WriteLine(stop.ToString("T"));
            Console.WriteLine(stop-start);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var st=new StopWatch();
            //Console.WriteLine("Press \'start\' to Start");
            //var userStart=Console.ReadLine();
            //if (userStart == "start")
            //    st.Start();

            //else {
            //    Console.WriteLine("Type Proper Word");
            //    userStart = Console.ReadLine();
            //}
            //Console.WriteLine("Press \'stop\' to Start");
            //var userStop = Console.ReadLine();
            //if (userStop == "stop")
            //    st.Stop();
            //else
            //{
            //    Console.WriteLine("Type Proper Word");
            //    userStop = Console.ReadLine();
            //}
            Console.WriteLine("Type start to start..");
            var user = Console.ReadLine();
            if (user == "start")
            {
                st.Start();
            }
            else
            {
                Console.WriteLine("Type start to start..");
                while (Console.ReadLine() != "start")
                {
                    Console.WriteLine("Type start to start..");
                }
            }
            Console.WriteLine("Type stop to stop..");
            user = Console.ReadLine();
            if (user == "stop")
            {
                st.Stop();
             

            }
            else
            {
                Console.WriteLine("Type stop to stop..");
                while (Console.ReadLine() != "stop")
                {
                    Console.WriteLine("Type stop to stop..");
                }
                
             

            }




        }
    }
}
