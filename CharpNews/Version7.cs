using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CharpNews
{
    class Version7
    {

        //static (string , string , int ) DoTupleNow()
        // named:
        static (string name, string title, int num) DoTupleNow()
        {
            return ("WOW", "YESY", 123);
        }

        static IEnumerable<(string name, int age)> GetIt((string name, int age) x)
        {
            yield return ("Shimon", 12);
            yield return ("Shimon", 12);
            yield return ("Shimon", 12);
            yield return ("Shimon", 12);
        }


        static void UseIt()
        {
            var res = DoTupleNow();
            var (n, t, num) = DoTupleNow();
        }



        // user ValueTask
        static async ValueTask<int> GetSum()
        {
            await Task.Delay(1000);
            return 3;
        }

        public static void UseOut()
        {
            var number = Console.ReadLine();
            //int x = int.Parse(number);
            // out variables
            var isNumber = int.TryParse(number, out int result);
            if (isNumber)
            {
                Console.WriteLine(result);
            }
        }

        static void UseLocal()
        {
            // local functions
            // static enabled only from vertion 8
            static void PrintNice(int number)
            {
                Console.WriteLine("WOW:" + number);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 90; j++)
                {
                    PrintNice(i * j);
                }
            }
        }

    }
}
