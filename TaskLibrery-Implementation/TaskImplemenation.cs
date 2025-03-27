using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLibrery_Implementation
{
    public class TaskImplemenation
    {
        public void CallMethod()
        {
            Console.WriteLine("Task Implementation started!");           

            var st = Stopwatch.StartNew();
            //Calling both methods parallelly. Two Threads will be created. Hence ShortRunningFunction will finish before LongRunningFunction
            var task1  = Task.Run(() => { LongRunningFunction(); });
            var task2 = Task.Run(() => { ShortRunningFunction(); });
            var task3 = Task.Run(() => { FastRunningFunction(); });

            var task4 = Task.Run(() => {
                LongRunningFunction();
                FastRunningFunction(); 
            
            });



            task4.GetAwaiter().GetResult();


            ////Calling both methods parallelly. Two Threads will be created. Hence ShortRunningFunction will finish before LongRunningFunction
            //Task.Run(() => { LongRunningFunction(); });
            //Task.Run(() => { ShortRunningFunction(); });

            st.Stop();
            Console.WriteLine($"Total Time Elapsed :{st.ElapsedMilliseconds}");
            Console.ReadLine();
        }

        //public int LongRunningFunction()
        //{
        //    // A Long running function
        //    Thread.Sleep(5000);
        //    Console.WriteLine("LongRunningFunction Finished!!!");
        //    return 1;
        //}

        //public int ShortRunningFunction()
        //{
        //    // A Short running function
        //    Thread.Sleep(2000);
        //    Console.WriteLine("ShortRunningFunction Finished!!!");
        //    return 2;
        //}

        //public int FastRunningFunction()
        //{
        //    // A Short running function            
        //    Console.WriteLine("FastRunningFunction Finished!!!");
        //    return 3;
        //}



        public int LongRunningFunction()
        {
            // A Long running function
            Thread.Sleep(5000);
            Console.WriteLine("LongRunningFunction Finished!!!");
            return 1;
        }

        public int ShortRunningFunction()
        {
            // A Short running function
            Thread.Sleep(2000);
            Console.WriteLine("ShortRunningFunction Finished!!!");
            return 2;
        }

        public int FastRunningFunction()
        {
            // A Short running function            
            Console.WriteLine("FastRunningFunction Finished!!!");
            return 3;
        }
    }
}
