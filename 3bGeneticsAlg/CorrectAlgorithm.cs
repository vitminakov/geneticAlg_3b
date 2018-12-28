using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3bGeneticsAlg
{
    class CorrectAlgorithm
    {

        public static void Swap(ref int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        //генерация первой перестановки
        public static int[] GetFirstPerm(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        public static Boolean GetNextPerm(ref int[] perm)
        {
            int n = perm.Length;
            int i = n - 1;
            for (; i > 0 && perm[i] < perm[i - 1]; i--) ;
            if (i == 0)
                return false;
            int j = n - 1;
            for (; j >= 0 && perm[j] < perm[i - 1]; j--) ;
            Swap(ref perm, i - 1, j);
            for (int k = 0; k <= (n - i) / 2 - 1; k++)
            {
                Swap(ref perm, k + i, n - k - 1);
            }
            return true;
        }


        //проверить во сколько ящиков влезут дискеты в заданном порядке
        private static int Check(int[] sizes, int[] comb, int capacity)
        {
            int res = 1;

            int disks = 0;
            for (int i = 0; i < comb.Length; i++)
            {
                if ((disks + sizes[comb[i]]) <= capacity)
                {
                    disks += sizes[comb[i]];
                }
                else
                {
                    disks = sizes[comb[i]];
                    res++;
                }
            }

            return res;
        }

        public static int[] GetRes(int[] res, int[] comb)
        {
            int[] answ= new int[comb.Length];
            for (int i = 0; i < comb.Length; i++)
            {
                answ[i]= res[comb[i]];
            }
            return answ;
        }
        //по сути возвращает лучшую перестановку
        public static int[] Run(int[] sizes, int capacity, out long time)
        {
            //подсчет времени
            time = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //проверяем есть ли файлы больше размера дискеты
            for (int i = 0; i < sizes.Length; i++)
            {
                if (sizes[i] > capacity)
                    return null;
            }

            //формируем первую перестановку
            Array.Sort(sizes);
            int res;//текущее количество дисков            
            int n = sizes.Length;
            int[] combination = GetFirstPerm(n);
            int min = Check(sizes, combination, capacity);
            int[] disks = (int[])combination.Clone();
            do
            {
                res = Check(sizes, combination, capacity);
                if (res < min)
                {
                    min = res;
                    disks = (int[])combination.Clone(); //сохраняем текущую перестановку
                }
            } while (GetNextPerm(ref combination));//пока есть переставноки, ищем минимальную

            //конец времени
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;

            return GetRes(sizes, disks);
        }
    }
}
