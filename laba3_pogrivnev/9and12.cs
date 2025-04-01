using array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sydorenko
{
    public class Varianti9_12
    {
        public static void Variant9(ref int[] myArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 9 - Знищити всі елементи між першим із максимальних за значенням і останнім із мінімальних за значенням; самі перший з максимальних та останній з мінімальних теж знищити; врахувати, що невідомо, який з них записано в масиві раніше");
            if (myArray == null || myArray.Length == 0)
            {
                Console.WriteLine("Масив порожній або не ініціалізований.");
                return;
            }
            myArray = RemoveMinMaxElements(myArray);
            ArrayMy.PrintArray(myArray);

        }
        static int FindFirstMax(int[] arr)
        {
            int max = arr[0], indexMax = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }
        static int FindLastMin(int[] arr)
        {

            int min = arr[0], indexmin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= min)
                {
                    min = arr[i];
                    indexmin = i;
                }
            }
            return indexmin;
        }
        static int[] RemoveMinMaxElements(int[] arr)
        {

            int maxIndex = FindFirstMax(arr);
            int minIndex = FindLastMin(arr);

            int start = Math.Min(maxIndex, minIndex);
            int end = Math.Max(maxIndex, minIndex);

            int[] newArr = new int[arr.Length - (end - start + 1)];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < start || i > end)
                {
                    newArr[index++] = arr[i];
                }
            }
            return newArr;
        }
        public static void Variant12(ref int[][] myJaggedArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("12. Додати рядок перед рядком, що містить максимальний елемент (якщо у різних місцях є кілька елементів з однаковим максимальним значенням, то брати останній з них");
            if (myJaggedArray == null || myJaggedArray.Length == 0)
            {
                Console.WriteLine("Зубчастий масив порожній або не ініціалізований.");
                return;
            }
            int maxindex = MaxValueJaggedArray(myJaggedArray);
            myJaggedArray = JaggedArray.AddRowBeforeMaxOrMinValue(myJaggedArray, maxindex);
            JaggedArray.PrintJaggedArray(myJaggedArray);

        }
        static int MaxValueJaggedArray(int[][] arr)
        {
            int max = int.MinValue, maxRow = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] >= max)
                    {
                        max = arr[i][j];
                        maxRow = i;
                    }
                }
            }
            return maxRow;
        }
    }
}
