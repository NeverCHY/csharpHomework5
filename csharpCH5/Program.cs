using System;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal cal = new Cal(2, 2);
            cal.pRin().Wait();
            Console.WriteLine(cal.a + cal.b);
        }
    }
}


using System.Threading.Tasks;
namespace p05
{

    public class Cal
    {
        public int a { set; get; }
        public int b { set; get; }
        public Cal(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public async Task pRin()
        {
            Task task0 = cal1();
            Task task1 = cal2();
            await task0;
            await task1;
        }
        public async Task cal1()
        {
            for (int i = 1; i < 58; i++)
            {
                a = a * 2;
                await Task.Delay(100);
            }

        }
        public async Task cal2()
        {
            for (int i = 1; i < 50; i++)
            {
                b = b * 2;
                await Task.Delay(100);
            }
        }
    }
}