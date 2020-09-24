using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseUSTB
{
    public class Homework1
    {
        public static void Program1()
        {
            Console.WriteLine("--------第一题如下：--------");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x < 1)
            {
                y = 2 * x - 5;
            }
            else if (x <= 10)
            {
                y = 2 * x;
            }
            else
            {
                y = 2 * x + 5;
            }
            Console.WriteLine(y);
            Console.WriteLine("--------第一题如上--------");
        }
        public static void Program2()
        {
            Console.WriteLine("--------第二题如下：--------");
            int x = Convert.ToInt32(Console.ReadLine());
            string seasons;
            switch (x)
            {
                case 1:
                    {
                        seasons = "Winter";
                        break;
                    }
                case 2:
                case 3:
                case 4:
                    {
                        seasons = "Spring";
                        break;
                    }
                case 5:
                case 6:
                case 7:
                    {
                        seasons = "Summer";
                        break;
                    }
                case 8:
                case 9:
                case 10:
                    {
                        seasons = "Autumn";
                        break;
                    }
                case 11:
                case 12:
                    {
                        seasons = "Winter";
                        break;
                    }
                default:
                    {
                        seasons = "Wrong Input!";
                        break;
                    }
            }
            Console.WriteLine(seasons);
            Console.WriteLine("--------第二题如上：--------");
        }
        public static void Program3()
        {
            Console.WriteLine("--------第三题如下：--------");
            int sum = 0;
            string result = "";
            int index = 1;
            while (index < 100)
            {
                sum += index;
                result += (Convert.ToString(index) + "+");
                index++;
            }
            sum += 100;
            result += ("100=" + Convert.ToString(sum));
            Console.WriteLine(result);
            Console.WriteLine("--------第三题如上--------");
        }
        public static void Program4()
        {
            Console.WriteLine("--------第四题如下：--------");
            int step = 1;
            while(!(step%2==1&&step%3==2&&step%5==4&&step%6==5&&step%7==0))
            {
                step++;
            }
            Console.WriteLine(step);
            Console.WriteLine("--------第四题如上--------");
        }
    }
}
