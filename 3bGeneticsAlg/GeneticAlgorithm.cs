using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace _3bGeneticsAlg
{
    class GeneticAlgorithm
    {
        private Random r;
        private Stopwatch stopWatch;
        public long CurTimeGen { get; set; }

        private int numOfChromosomes; //кол-во хромосом
        private int[] sizes; // размеры файлов
        private int mutationPercent; // процент мутаций
        private int mutationCount;
        private int cntParentChromes;
        private int capacity;// размер носителя

        bool detected = false;
        int[] answer;

        List<Chromosome> firstGeneraion;
        List<Chromosome> currentGeneraion;

        //инициализация
        public GeneticAlgorithm(int _numOfChrom, int[] _Sizes, int _Capacity, int _mutPercent, int _mutCnt, int _cntParentChromes)
        {
            r = new Random();
            numOfChromosomes = _numOfChrom;
            sizes = _Sizes;
            capacity = _Capacity;
            mutationPercent = _mutPercent;
            mutationCount = _mutCnt;
            cntParentChromes = _cntParentChromes;
        }



        //запуск алгоритма
        public int[] Run(int steps)
        {

            stopWatch = new Stopwatch();
            stopWatch.Start();
            SetFirstGeneration();//генерация начального состояния
            if (CheckAll(firstGeneraion))
            {
                detected = true;
                return answer;
            }

            SortPopulation(firstGeneraion);
            currentGeneraion = firstGeneraion;
            int step = 2;
            while (!detected && (step <= steps))
            {
                //Cледующее поколение
                GetNextGeneration(currentGeneraion, step);
                if (CheckAll(currentGeneraion)) detected = true;
                SortPopulation(firstGeneraion);
                step++;

            }
            // если не нашли идеальное решение, то выбираем лучшее среди последней популяции
            CheckBestAll(currentGeneraion);
            stopWatch.Stop();
            CurTimeGen = stopWatch.ElapsedTicks;
            return answer;
        }

        //проверка генераций
        private bool CheckAll(List<Chromosome> generaion)
        {
            for (int i = 0; (i < firstGeneraion.Count) && !detected; i++)
            {
                if (generaion[i].CheckChromosome(sizes,capacity))
                {
                    answer = generaion[i].GetCurrentSolve(sizes);
                    detected = true;
                }
            }
            return detected;
        }

        //находим особь с самым большим коэффициентом выживания среди поколения
        private bool CheckBestAll(List<Chromosome> generaion)
        {
            Chromosome BestCB = generaion.ElementAt(1);
            for (int i = 0; i < firstGeneraion.Count; i++)
            {
                if (generaion[i].Fitness>BestCB.Fitness)
                {
                    BestCB = generaion[i];
                }
            }
            answer = BestCB.GetCurrentSolve(sizes);

            detected = true;
            return detected;
        }

        //Генерация случайного начального состояния.
        private void SetFirstGeneration()
        {
            firstGeneraion = new List<Chromosome>();
            for (int j = 0; firstGeneraion.Count < numOfChromosomes;)
            {
                Chromosome ch = new Chromosome(sizes,capacity, r);//генерируем новую хромосому
                if (!ch.IsEmpty())
                {
                    firstGeneraion.Add(ch);
                    j++;
                }
            }
        }

        //получить следующую генерацию
        private void GetNextGeneration(List<Chromosome> curGen, int step)
        {
            List<Chromosome> newGeneration = new List<Chromosome>();
            double p = 0;
            double[] ver = new double[curGen.Count];
            foreach (Chromosome ch in curGen)
            {
                p += ch.Fitness;
            }
            ver[0] = (1 - ((double)curGen[0].Fitness / p)) / (ver.Length - 1);
            for (int i = 1; i < ver.Length; i++)
            {
                ver[i] = ver[i - 1] + (1 - ((double)curGen[i].Fitness / p)) / (ver.Length - 1);
            }

            //Воспроизводство
            for (int i = 0; i < cntParentChromes; i++)
            {
                newGeneration.Add(curGen[Choosed(ver)]);
            }
            while(newGeneration.Count < curGen.Count)
            {
                Chromosome newChild = Selection(newGeneration[r.Next(cntParentChromes)], newGeneration[r.Next(cntParentChromes)]);
                if (!newChild.IsEmpty() && newGeneration.Count < curGen.Count) newGeneration.Add(newChild);
            }

            Mutation(newGeneration);
            curGen = newGeneration;
        }

        //мутация
        private void Mutation(List<Chromosome> generation)
        {

            for (int i = 0; i < mutationCount; i++)
            {
                int num = r.Next(0, generation.Count);
                generation[num].Mutate(mutationPercent);
                generation[num].SetFitness(sizes,capacity);
            }
        }

        //выбор
        private int Choosed(double[] ver)
        {
            double curVer = r.NextDouble();
            for (int i = 0; i < ver.Length; i++)
            {
                if (curVer < ver[i])
                    return i;
            }
            return ver.Length - 1;
        }

        //сортировка популяции
        public void SortPopulation(List<Chromosome> population)
        {
            int k;
            Chromosome x;
            for (int i = 0; i < population.Count; i++)
            {   // i - номер текущего шага
                k = i;
                x = population[i];
                for (int j = i + 1; j < population.Count; j++)  // цикл выбора элемента с наибольшим коэффициентом выживания
                    if (population[j].Fitness > x.Fitness)
                    {
                        k = j;
                        x = population[j];// k - индекс элемента с наибольшим коэффициентом выживания
                    }

                population[k] = population[i];
                population[i] = x; // меняем местами с popullation[i]
            }
        }

        //генерация новой хромосомы с "мамой" и "папой" и вычисление ее коэффициента выживаемости
        private Chromosome Selection(Chromosome father, Chromosome mother)
        {
            Chromosome child = new Chromosome(father, mother, r);
            child.SetFitness(sizes, capacity);
            return child;
        }


    }
}
