namespace MyWebJob
{
    using System;

    using Microsoft.Azure.WebJobs;

    using Model;

    public class Program
    {
        public static void Main(string[] args)
        {
            var logic = new SomeBusinessLogic();
            Console.WriteLine(logic.GetValue());
            var host = new JobHost();
            host.RunAndBlock();
        }
    }
}
