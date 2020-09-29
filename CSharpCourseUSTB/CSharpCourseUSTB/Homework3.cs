using System;
using System.Collections;

namespace CSharpCourse
{
    public class Homework3
    {
        public static void Program1()
        {
            Console.WriteLine("--------第一题如下：--------");
            String inputStr;
            Queue myQueue = new Queue();
            inputStr = Console.ReadLine();
            while (!inputStr.Equals("over"))
            {
                myQueue.Enqueue(inputStr);
                Console.WriteLine(inputStr + "已加入到队列");
                inputStr = Console.ReadLine();
            }
            foreach (String item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------第一题如上：--------");
        }
        public static void Program2()
        {
            Console.WriteLine("--------第二题如下：--------");
            int[] arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next();
            }

            Console.WriteLine("开始遍历整型数组");
            Stack stack = new Stack();
            foreach (int item in arr)
            {
                stack.Push(item);
                Console.WriteLine(item);
            }
            Console.WriteLine("遍历整型数组结束");
            Array.Clear(arr, 0, arr.Length);//清空数组
            Console.WriteLine("已清空数组，尝试从栈中恢复");

            for (int i = 9; i >= 0; i--)
            {
                arr[i] = Convert.ToInt32(stack.Pop());
            }
            Console.WriteLine("遍历恢复后数组");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------第二题如上：--------");
        }
        public static void Program3()
        {
            Console.WriteLine("--------第三题如下：--------");
            ArrayList arrayList
            Console.WriteLine("--------第三题如上：--------");
        }
    }
}
