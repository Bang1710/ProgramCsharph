using System;

namespace File_code_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2== 0)
                {
                    S+=i;
                }
            }
            Console.WriteLine("Tong cua nhung so chan {0} ",S);
        }
    }
}
