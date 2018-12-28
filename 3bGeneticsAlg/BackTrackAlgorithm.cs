using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3bGeneticsAlg
{
    class BackTrackAlgorithm
    {

        private static int min;
        private static int[] bestmas;
        private static int n;
        private static int[] sizes;
        private static int capacity;

        //поменять элементы местами
        public static void Swap(ref int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        //получение первого решения
        public static int[] GetFirstPerm(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
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

        //переводит перестановку в список строк по дискам
        public static int[] GetRes(int[] res, int[] comb)
        {
            int[] answ = new int[comb.Length];
            for (int i = 0; i < comb.Length; i++)
            {
                answ[i] = res[comb[i]];
            }
            return answ;
        }

        //бектрекинг
        public static void Solve(int[] curper, int i)
        {
            if (i == n)
            {
                if (min > Check(sizes, curper, capacity))
                {
                    min = Check(sizes, curper, capacity);
                    bestmas = (int[])curper.Clone();
                }
            }
            else
            {
                Solve(curper, i + 1);
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (curper[i] != curper[j])
                    {
                        Swap(ref curper, i, j);
                        Solve(curper, i + 1);
                        Swap(ref curper, i, j);
                    }
                }
            }
        }

        //по сути возвращает минимальный список ящиков с их содержимым
        public static int[] FindRes(int[] size, int cap, out long time)
        {
            //инициализация private полей
            sizes = size;
            capacity = cap;
            n = sizes.Length; //длинна перестановки

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
            int[] combination = GetFirstPerm(n);
            //заносим в минимум первую перестановку
            min = Check(sizes, combination, capacity);
            bestmas = (int[])combination.Clone();

            Solve(combination, 0);

            //конец времени
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;

            return GetRes(sizes, bestmas);
        }
    }
}
