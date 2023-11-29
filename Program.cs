using System;


namespace Day4
{
    internal class Program
    {
        readonly int a = 10;
        public int b { get; set; }



        static void Main(String[] args)


        {
            // int a=20;
            // int x;
            // int num;
            // var res1 = int.Parse("5");
            //// Console.WriteLine(res1);
            // var res = int.TryParse("5",out num);
            // Console.WriteLine(res);
            // Console.WriteLine(num);
            //// Console.WriteLine(res);
            // var b = new Boy { Name="jeet"};
            // //Console.WriteLine(b.Name);
            // // var p=new Program();
            // //  Console.WriteLine(Program.a);
            // //  Console.WriteLine(add(1,2,3,4,4 ));
            // // Console.WriteLine(Add( a));

            var boy = new Boy();
            //boy.SetId(1);   
            //boy.SetName("A");
            //Console.WriteLine(boy.GetName());
            //Console.WriteLine(boy.GetId());
            //boy.id = 1;
            //Console.WriteLine(boy.id);
            //boy.name = "jay";
            //Console.WriteLine(boy.name);
           


        }
        public static int add(params int[] num)
        {
            var sum = 0;
            for (var i = 0; i < 5; i++)
            {
                sum = sum + num[i];
            }
            return sum;
        }

        public static int Add(int n)
        {

            int a = n + 2;
            return a;
        }



    }
}
//    