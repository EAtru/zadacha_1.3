using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write("Введите первый массив: ");
            int[] A = new int[5];
            for (int i = 0; i < 5; i++)
                A[i] = int.Parse(Console.ReadLine());
            Console.Write("Введите второй массив: ");
            int[] B = new int[5];
            for (int i = 0; i < 5; i++)
                B[i] = int.Parse(Console.ReadLine());
            Console.Write("Введите номер элемента начала вставки: ");
            k = Convert.ToInt32(Console.ReadLine());

            int[] mass = new int[A.Length + B.Length];

            if (k > 0 && k < A.Length)
            {

                int buf = k + 1;

                int s = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (i <= k)
                        mass[i] = A[i];
                    if (i > k && i <= k + B.Length)
                    {
                        mass[i] = B[s];
                        s++;
                    }
                    if (i > k + B.Length)
                    {

                        mass[i] = A[buf];
                        buf++;
                    }
                }
            }
            foreach (int ar in mass)
                Console.Write(" " + ar);
            Console.ReadLine();

        }
    }
}
