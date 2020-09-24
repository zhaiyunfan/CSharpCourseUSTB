using System;
namespace CSharpCourseUSTB
{
    public class Homework2
    {
        public static void Program1()
        {
            //数组解法
            Console.WriteLine("--------第一题如下：--------");
            int[] arr = new int[33];
            int[] result = new int[7];
            for (int i = 0; i < 33; i++)
            {
                arr[i] = -1;
            }
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                int temp = random.Next() % 33;
                if ((arr[temp] != -1) || (temp + 1) % 10 == 4)
                {
                    i--;
                }
                else
                {
                    arr[temp] = 1;
                    result[i] = (temp) + 1;
                }
            }
            Array.Sort(result);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------第一题如上：--------");
        }
        public static void Program2()
        {
            Console.WriteLine("--------第二题如下：--------");
            string[,] poem = {
                {"床","前","明","月","光"},
                {"疑","是","地","上","霜"},
                {"举","头","望","明","月"},
                {"低","头","思","故","乡"}
            };
            Console.WriteLine("\n下面是横版\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(poem[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n下面是竖版\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(poem[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------第二题如上：--------");

        }
        public static void Program3()
        {
            Console.WriteLine("--------第三题如下：--------");
            Random random = new Random();
            int[,] arr = new int[3, 4];
            Console.WriteLine("生成的数组如下");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = random.Next(13);
                    Console.Write(arr[i, j]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }
            int max = -1;
            int m = 0, n = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        m = i;
                        n = j;
                    }
                }
            }
            Console.WriteLine("最大值为" + max);
            Console.WriteLine("行号为" + (m + 1) + ",列号为" + (n + 1));
            Console.WriteLine("--------第三题如上：--------");

        }
    }
}
