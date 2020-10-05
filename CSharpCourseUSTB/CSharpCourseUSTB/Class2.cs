using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseUSTB
{
    public class Class2
    {
        static ArrayList myStack = new ArrayList();

        static void push(object obj)
        {
            myStack.Add(obj);
        }

        static object pop()

        {
            object result = myStack[myStack.Count - 1];
            myStack.RemoveAt(myStack.Count - 1);
            return result;
        }

        static bool stackEmpty()
        {
            return myStack.Count > 0 ? false : true;
        }


        public static void Program1()
        {
            Console.WriteLine("--------第一题如下：--------");
            decimal sum = 0;
            int num = 10000000;
            DateTime startTime = DateTime.Now;
            for (decimal i = 0; i < num; i++)
            {

                if (i % 2 == 0)
                {
                    sum += 1 / ((2 * i) + 1);
                }
                else
                {
                    sum -= 1 / ((2 * i) + 1);
                }
            }
            sum *= 4;
            DateTime endTime = DateTime.Now;
            Console.WriteLine("PI=" + sum);
            Console.WriteLine("迭代" + num + "次所用时间" + (endTime - startTime));
            Console.WriteLine("--------第一题如上--------");
        }
        public static void Program2()
        {
            Console.WriteLine("--------第二题如下：--------");
            push("abc");
            push(123);
            while (true)
            {
                if (!stackEmpty())
                {
                    Console.WriteLine(pop());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("--------第二题如上--------");
        }
    }
}
