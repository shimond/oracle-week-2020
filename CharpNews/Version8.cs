using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpNews
{
    class Version8
    {

        public static void UseIndexAndRange()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"arr[^1] = {arr[^1]}");
            var split = arr[4..7];
            Console.WriteLine("Values of arr[4..7]");
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }

            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var splitList = list[^4];
            Console.WriteLine("Values of arr[4..7]");
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }

        }

        public static async Task Start()
        {
            await foreach (var item in ReadFromFile("c:\\temp\\temp.txt"))
            {
                Console.WriteLine(item);
            }

            await foreach (var item in ReadFromFile("c:\\temp\\temp.txt"))
            {
                Console.WriteLine(item);
                break;
            }

            Console.WriteLine("FINITO");
        }

        // Use IAsyncEnumerable
        public static async IAsyncEnumerable<string> ReadFromFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (StreamReader reader = new StreamReader(fs))
                while (!reader.EndOfStream)
                {
                    string currentLine = await reader.ReadLineAsync();
                    await Task.Delay(9000);
                    yield return currentLine;
                }
        }


    }
}
