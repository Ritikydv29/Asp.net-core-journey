namespace Asynchronous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fun1();
            fun2();
            fun3();
            Console.ReadLine();
        }
        public async static void fun1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task1 Started");
                Thread.Sleep(4000);
                Console.WriteLine("task1 Completed");
            });
        
        }
        public async static void fun2()
        {
          await Task.Run(() =>
            {
                Console.WriteLine("task2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("task2 Completed");
            });
        }
        public async static void fun3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task3 Started");
            Thread.Sleep(3000);
            Console.WriteLine("task3 Completed");
            });
        }
    }
}
