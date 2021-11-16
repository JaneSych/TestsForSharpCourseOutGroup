using System;
using System.Linq;
namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        {
            if (temp.Max() > 0 && temp.Min() < 0)
            {
                int MinP = temp.Max();
                foreach (int i in temp)
                {
                    if (i > 0 && i <= MinP)
                    {
                        MinP = i;
                    }
                }

                int MaxNID = Array.IndexOf(temp, temp.Min());
                int MinPID = Array.IndexOf(temp, MinP);
                
                temp[MinPID] = temp.Min();
                temp[MaxNID] = MinP;
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
        {
            int ArrSum = 0;
            for (int i = 2; i < temp.Length; i += 2)
            {
                ArrSum += temp[i];
            }
            return ArrSum;
        }

        /// <summary>
        /// В массиве целых чисел заменить нулями отрицательные элементы.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
        public static int[] Variant3(int[] temp)
        {
            for (int i = 0; i < temp.Length; i ++)
            {
                if (temp[i] < 0)
                {
                    temp[i] = 0;
                }
                        
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
        public static int[] Variant4(int[] temp)
        {
            for (int i = 0; i < temp.Length-1; i ++)
            {
                if (temp[i] > 0 && temp[i+1] < 0)
                {
                    temp[i] *= 3;
                    i++;
                }
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
        public static double Variant5(int[] temp)
        {
            return ((double)temp.Sum() / temp.Length) - temp.Min();
        }
    }
}