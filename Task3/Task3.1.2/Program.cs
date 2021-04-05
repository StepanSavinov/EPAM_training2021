using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace epamXT
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = WordCounter(AppDomain.CurrentDomain.BaseDirectory + @"\TEXT.txt");

            foreach (var pair in document)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value + Environment.NewLine);
            }
        }

        public static Dictionary<string, int> WordCounter(string filePath)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var count = 0;

            foreach (var line in File.ReadLines(filePath))
            {
                foreach (var word in line.Split(';', ',', ' ').Skip(1))
                {
                    result.TryGetValue(word, out count);
                    result[word] = count + 1;
                }
            }

            return result;
        }
    }
}