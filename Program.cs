using System;

namespace bai1
{
    class Program
  {

    static void timuocso(){
         Console.OutputEncoding = System.Text.Encoding.UTF8;
            int  i , n1 , n2 , j , uscln  =  1 ;
            Console.Write("Nhập a: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            j = (n1 < n2) ? n1 : n2;
            for (i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    uscln = i;
                }
            }
            Console . Write ( " n The greatest common divisor of {0} and {1} is: {2} n  n " , n1 , n2 , uscln );
    }
        static void Main(string[] args)
        {
           
            timuocso();
            Console.ReadKey();
        }
    }
}
