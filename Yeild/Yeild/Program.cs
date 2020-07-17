using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeild
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] scores = { 10, 20 ,30 };
            //var scores = GetAllScores();
            foreach (var score in GetAllScores())
            {
                Console.WriteLine(score);
            }

            foreach (var score in GetScores())
            {
                Console.WriteLine("yield문"+ score);
            }

            foreach (var total in 누적합계())
            {
                Console.WriteLine("누적합계" + total);
            }
        }
        static int[] GetAllScores()
        {
            int[] scores = new int[] { 10, 20, 30 };
            return scores;
        }

        static IEnumerable<int> GetScores()
        {
            int[] scores = new int[] { 10, 20, 30, 40 ,50 };
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 30)
                {
                    yield break;
                }
                yield return scores[i];
                Debug.WriteLine(i + " : Done");
            }
        }

        static IEnumerable<int> 누적합계()
        {
            int[] scores = new int[] { 10, 20, 30, 40, 50 };
            int total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
                yield return total;
            }
        }
    }
}
