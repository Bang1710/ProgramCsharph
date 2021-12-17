using System;

namespace File_code_C_
{
    class Program
    {
        /// <summary>
        /// Tính tổng hai số nguyên
        /// </summary>
        /// <param name="a">số thứ nhất</param>
        /// <param name="b">số thứ hai</param>
        /// <returns>giá trị a + b</returns>
        static int TongHaiSo(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    S += i;
                }
            }
            Console.WriteLine("Tong cua nhung so chan {0} ", S);
            TongHaiSo(10, 12);
        }
    }
}
