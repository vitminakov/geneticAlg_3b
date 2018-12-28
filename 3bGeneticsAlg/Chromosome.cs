using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3bGeneticsAlg
{
    //класс содержащий перестановку двух элементов. файлы, которые можно поменять местами
    public class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Pair() {
            First = 0;
            Second = 0;
        }
    }

    class Chromosome
    {
        Random r;
        private Pair[] Code { get; set; }// перестановки файлов по дискам
        public int Fitness { get; set; }// коэффициент приспосабливаемости
        int Size { get; set; }

        public Chromosome(int[] sizes, int capacity,  Random _r)
        {
            r = _r;
            Code = new Pair[sizes.Length];
            for (int i = 0; i < sizes.Length; i++)
            {
                Code[i] = new Pair();
                Code[i].First = r.Next(sizes.Length-1);
                Code[i].Second = r.Next(sizes.Length-1);
            }
            SetFitness(sizes, capacity);
            Size = Code.Length;
        }

        //получаем левую часть от "папы" и левую от "мамы"  
        public Chromosome(Chromosome f, Chromosome m, Random _r)
        {
            r = _r;
            int b = r.Next(1, f.Size-1);//выбор рандомной точки, по которой будем делить
            
            Code = new Pair[f.Size];
            for (int i = 0; i < f.Size; i++)
            {
                Code[i] = i < b ? f.Code[i] : m.Code[i];
            }         
        }

        //мутация гена
        public void Mutate(int percent)
        {
            if (r.Next(1, 100) <= percent)
            {
                int num = r.Next(0, Code.Length);
                Code[num].First = r.Next(Code.Length-1);
                Code[num].Second = r.Next(Code.Length-1);
            }
        }

        // переставить элементы массива
        public static void Swap(ref int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        //получить текущее решение (размещение файлов по дискетам)
        public int[] GetCurrentSolve(int[] sizes)
        {
            int[] Solve = new int[sizes.Length];
            for(int i=0; i< sizes.Length; i++)
            {
                Solve[i] = sizes[i];
            }

            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i]!=null)//поменять файлы, которые нужно поменять
                    Swap(ref Solve, Code[i].First, Code[i].Second);
            }
            return Solve;
        }

        //возвращает количество дискет необходимых для записи всех файлов (для текущего решения!)
        public int GetCountDisk(int[] sizes, int capacity)
        {
            int[] Solve = GetCurrentSolve(sizes);//текущее решение
            int res = 1;

            int disks = 0;
            for (int i = 0; i < Solve.Length; i++)
            {
                if ((disks + Solve[i]) <= capacity)
                {
                    disks += Solve[i];
                }
                else
                {
                    disks = Solve[i];
                    res++;
                }
            }
            return res;
        }

        /*Вычисление коэффициента выживаемости
         Худшее решеение каждый файл на отдельной дискете.
         Лучшее решение – объем файлов / размер носителя. 
         Коэффициент выживаемости = худшее решение - текущее*/
        public void SetFitness(int[] sizes, int capacity)
        {
            Fitness = sizes.Length - GetCountDisk(sizes, capacity);
        }

        // является ли текущее решение лучшим
        public bool CheckChromosome(int[] sizes, int capacity)
        {
                int AllFilesSize = 0;
                for (int i = 0; i < sizes.Length; i++)
                    AllFilesSize += sizes[i];
                // количество дискет для записи текущего решения равно минимальному кол-ву дискет
                return GetCountDisk(sizes, capacity) == ((AllFilesSize%capacity==0) ? AllFilesSize / capacity : 1+ AllFilesSize / capacity);
        }

        // определяет, существуют ли перестановки элементов
        public bool IsEmpty()
        {
            foreach (Pair el in Code)
                if (el.First != el.Second) return false;
            return true;
        }

    }
}
