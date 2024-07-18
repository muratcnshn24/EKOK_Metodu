using System;

namespace EKOK_Metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("OKEK({0},{1})= {2}",s1,s2, Matematik.OKEK((int) s1,(int) s2));
        }
    }
}
