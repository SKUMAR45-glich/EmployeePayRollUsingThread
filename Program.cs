using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EmployeePayRollThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee PayRoll Using Threads");

            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

            #region ParallelTasks

            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin First Task ");
                GetLongestWord(words);
            },

            () =>
            {
                Console.WriteLine("Begin second task ");
                GetMostCommonWords(words);
            },

            () =>
            {
                Console.WriteLine("Begin Third task ");
                GetMostCommonWords(words);

            }
            );
        }
        #endregion

        public static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving from {uri}");
            string blog = new WebClient().DownloadString(uri);
            return blog.Split(
                new char[] { ' ', '\u000A', '_', '-', ',', '/' },
                StringSplitOptions.RemoveEmptyEntries
                );
        }

        public static string GetLongestWord(string[] words)
        {
            string longestWord = (from w in words
                                  orderby w.Length descending
                                  select w).First();
            Console.WriteLine($"Task 1 Longest word is {longestWord}");
            return longestWord;
        }

        public static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from w in words
                                 where w.Length > 6
                                 group w by w into q
                                 orderby q.Count() descending
                                 select q.Key;

            var commonWord = frequencyOrder.Take(10);
        }

    }
}


