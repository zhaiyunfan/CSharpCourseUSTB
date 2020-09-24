using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseUSTB
{
    public class Class1
    {       
        public static void Program1()
        {
            Console.WriteLine("--------第一题如下：--------");
            double x = 10000.0;
            double rate = 0.1;
            for (int i = 0; i < 8; i++)
            {
                x += x * rate;
            }
            Console.WriteLine(x.ToString("0.##") + "元");
            Console.WriteLine("--------第一题如上--------");
        }
        public static void Program2()
        {
            Console.WriteLine("--------第二题如下：--------");
            Console.WriteLine("请输入待计算的x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Sin(x) + 2 * Math.Sqrt((x + Math.Exp(14))) - Math.Pow((x + 1), 3);
            Console.WriteLine(y);
            Console.WriteLine("--------第二题如上--------");
        }
        public static void Program3()
        {
            Console.WriteLine("--------第三题如下：--------");
            Console.WriteLine("请分行输入矩形的两边长:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入圆的直径");
            double d = Convert.ToDouble(Console.ReadLine());
            double r = d / 2;

            double CDouble1 = 0;//矩形周长
            int CInt1 = 0;//矩形周长
            double SDouble1 = 0;//矩形面积
            int SInt1 = 0;//矩形面积

            double CDouble2 = 0;//圆形周长
            int CInt2 = 0;//圆形周长
            double SDouble2 = 0;//圆形面积
            int SInt2 = 0;//圆形面积

            try
            {
                checked
                {
                    CDouble1 = 2 * (x + y);
                    CInt1 = (int)(2 * (x + y));
                    SDouble1 = x * y;
                    SInt1 = (int)(x * y);

                    CDouble2 = d * Math.PI;
                    CInt2 = (int)(d * Math.PI);
                    SDouble2 = r * r * Math.PI;
                    SInt2 = (int)(r * r * Math.PI);
                }
            }
            catch
            {
                Console.WriteLine("发生溢出");
            }
            Console.WriteLine("矩形的周长用double输出为" + Convert.ToString(CDouble1));
            Console.WriteLine("矩形的周长用int输出为" + Convert.ToString(CInt1));
            Console.WriteLine("矩形的面积用double输出为" + Convert.ToString(SDouble1));
            Console.WriteLine("矩形的面积用int输出为" + Convert.ToString(SInt1));

            Console.WriteLine("圆形的周长用double输出为" + Convert.ToString(CDouble2));
            Console.WriteLine("圆形的周长用int输出为" + Convert.ToString(CInt2));
            Console.WriteLine("圆形的面积用double输出为" + Convert.ToString(SDouble2));
            Console.WriteLine("圆形的面积用int输出为" + Convert.ToString(SInt2));
            Console.WriteLine("--------第三题如上--------");
        }


    }
}
