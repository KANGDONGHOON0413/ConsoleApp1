using System;

//delegate조합 복습
namespace day14_01
{
    class Program
    {
        delegate void dele(string str);
        class test01
        {
            public void Print_A(string str)
            {
                Console.WriteLine(str);
            }
            public void Print_B(string str)
            {
                Console.WriteLine("\t" + str);
            }
        }
        class test02
        {
            public void Print_C(string str)
            {
                Console.WriteLine("\t\t" + str);
            }
        }
        static void Main(string[] args)
        {
            test01 t01 = new test01();
            var t02 = new test02();
          
            //2번 방법
            dele D1 = t01.Print_A;
            D1 += t01.Print_B;
            D1 += t02.Print_C;
            D1("ABC");
            D1 -= t01.Print_B;
            D1("AC");
        }
    }
}