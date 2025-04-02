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
        public async Task CallMethod()
        {
            Console.WriteLine("Task Implementation started!");           

            var st = Stopwatch.StartNew();
            //Calling both methods parallelly. Two Threads will be created. Hence ShortRunningFunction will finish before LongRunningFunction
            //var task1  = Task.Run(() => { LongRunningFunction(); });
            //var task2 = Task.Run(() => { ShortRunningFunction(); });
            //var task3 = Task.Run(() => { FastRunningFunction(); });

            //var task4 = Task.Run(() => {
            //    LongRunningFunction();
            //    FastRunningFunction(); 

            //});

            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => LongRunningFunction()));
            tasks.Add(Task.Run(() => ShortRunningFunction()));
            tasks.Add(Task.Run(() => FastRunningFunction()));

            Task.WhenAll(tasks);

            Console.WriteLine("Fisrt part finished");
            
            var task1 = Task.Run(() => LongRunningFunction());
            var task2 = Task.Run(() => ShortRunningFunction());
            var task3 = Task.Run(() => FastRunningFunction());

            //
            Task.WaitAll(task1, task2, task3);
            

            int a3 = task3.Result;
            int a2 = task2.Result;
            int a1 = task1.Result;

            Console.WriteLine("Second part finished");

            Task.Run(() => FastRunningFunction());


            // Console.WriteLine($"Result1 :{res1} and Result2 : {res2}");
            ////Calling both methods parallelly. Two Threads will be created. Hence ShortRunningFunction will finish before LongRunningFunction
            //Task.Run(() => { LongRunningFunction(); });
            //Task.Run(() => { ShortRunningFunction(); });


            Parallel.For(0, 9, i =>
            {
                Console.WriteLine($"Task {i} started.");
                Task.Delay(1000).Wait();
                Console.WriteLine($"Task {i} completed.");
            });

            Parallel.ForEach(tasks, t =>
            {
                Console.WriteLine($"Task {t} started.");
                Task.Delay(1000).Wait();
                Console.WriteLine($"Task {t} completed.");
            });

            ////////////////////////////////////////////////////////////////////////////////
            //Return multiple values from Async method
            var result = await GetMultipleReturnValue(1);
            int a = result.Item1;
            string b = result.Item2;


            st.Stop();
            Console.WriteLine($"Total Time Elapsed :{st.ElapsedMilliseconds}");
            Console.ReadLine();
        }

      
        public int LongRunningFunction()
        {
            // A Long running function
            Task.Delay(6000);
            Console.WriteLine("LongRunningFunction Finished!!!");
            return 1;
        }

        public int ShortRunningFunction()
        {
            // A Short running function
            Task.Delay(2000);
            Console.WriteLine("ShortRunningFunction Finished!!!");
            return 2;
        }

        public int FastRunningFunction()
        {
            // A Short running function            
            Console.WriteLine("FastRunningFunction Finished!!!");
            return 3;
        }

        //Return multiple values from Async method
        public async Task<(int,string)> GetMultipleReturnValue(int a)
        {           
            int taskId = 10;
            string taskType = "returnTypes";
           
            return (taskId, taskType);
        }

    }
}
