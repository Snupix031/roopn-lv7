using System;


namespace lv7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 i 2 zadatak
            //double[] arr = new double[] { 3, 1, 6, 5, -36, 23, 15.1, -12.01 };
            //NumberSequence sequence = new NumberSequence(arr);
            //BubbleSort bubble = new BubbleSort();
            //sequence.SetSortStrategy(bubble);

            //Console.WriteLine("Prije:\n" + sequence.ToString());

            //sequence.Sort();
            //Console.WriteLine("Poslije:\n" + sequence.ToString());

            //LinearSearch linearSearch = new LinearSearch();
            //sequence.SetSearchStrategy(linearSearch);
            //Console.WriteLine(sequence.Search(6));
            SystemDataProvider provider = new SystemDataProvider();
            FileLogger logger = new FileLogger("prvi.txt");
            FileLogger logger2 = new FileLogger("drugi.txt");
            ConsoleLogger log = new ConsoleLogger();
            provider.Attach(log);
            provider.Attach(logger);
            provider.Attach(logger2);

            for (; ; )
            {

                provider.GetAvailableRAM();
                provider.GetCPULoad();


                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
