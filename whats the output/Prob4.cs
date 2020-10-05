//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.whats_the_output
//{
//    public class Counter

//    {

//        private static object @sync = new object();



//        public int ThreadMethod(int i)

//        {

//            lock (@sync)

//            {

//                var j = i - 1;



//                if (i == 1)

//                {

//                    Console.Write($"Thread Completed; ");

//                    return 1;

//                }



//                this.ThreadMethod(j);

//                return 0;

//            }

//        }



//    }



//    class Program

//    {



//        static void Main(string[] args)

//        {

//            var counter = new Counter();



//            var task1 = Task.Run(() => counter.ThreadMethod(5));

//            var task2 = Task.Run(() => counter.ThreadMethod(6));



//            Task.WaitAll(task1, task2);

//        }

//    }
//}
