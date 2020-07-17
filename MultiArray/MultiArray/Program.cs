using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array3d = new int[,,] { { {1,2,3 },{4,5,6 } },
                                            { {7,8,9 },{10,11,12 } } };

            Console.WriteLine(array3d[1, 0, 1]);

            // 가변 배열
            // 1차 배열 크기는 명시해야
            /*
             * A = [1 2   ]
             *     [1 2 3 ]
             *     [1 2 3 4]
             */
            int[][] A = new int[3][];

            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            Console.WriteLine(A[2][0]);

            //int sum = 0;
            //int[] scores = { 80, 95, 80, 70, 85 };
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}
            //Console.WriteLine(sum);

            int[] scores = { 80, 95, 80, 70, 85 };
            int sum = Calculate(scores); // 배열전달: 배열명 사용
            Console.WriteLine(sum);
        }
        static int Calculate(int[] scoresArray) //배열 받는 쪽
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }
    }
}
