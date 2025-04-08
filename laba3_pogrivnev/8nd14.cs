using System;
using System.Text;
using System.Collections.Generic;
using array;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace holtvanski
{
    public class Varianti8_14
    {
        public static void Variant8(ref int[] myArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 8 - Знищити всі елементи з непарними індексами");

            if (myArray == null || myArray.Length == 0)
            {
                Console.WriteLine("Масив порожній або не ініціалізований.");
                return;
            }

            myArray = RemoveOddIndexElementsHuman(myArray);
            // RemoveOddIndexElementsResize(ref myArray);
            // myArray = RemoveOddIndexElementsList(myArray);

            ArrayMy.PrintArray(myArray);
        }

        static int[] RemoveOddIndexElementsHuman(int[] arr)
        {
            int newSize = arr.Length / 2; 
            int[] newArr = new int[newSize];
            int index = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                newArr[index++] = arr[i];
            }

            return newArr;
        }

        static void RemoveOddIndexElementsResize(ref int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                arr[index++] = arr[i];
            }

            Array.Resize(ref arr, index);
        }

        static int[] RemoveOddIndexElementsList(int[] arr)
        {
            List<int> newArr = new List<int>();
            for (int i = 0; i < arr.Length; i += 2)
            {
                newArr.Add(arr[i]);
            }
            return newArr.ToArray();
        }

        public static void Variant14(ref int[][] myJaggedArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 14 - Додати рядок після рядка з останнім мінімальним елементом");

            if (myJaggedArray == null || myJaggedArray.Length == 0)
            {
                Console.WriteLine("Зубчастий масив порожній або не ініціалізований.");
                return;
            }
            myJaggedArray = AddRowAfterMinValue(myJaggedArray);
            // AddRowAfterMinValueResize(ref myJaggedArray);
            //myJaggedArray = AddRowAfterMinValueList(myJaggedArray);

            JaggedArray.PrintJaggedArray(myJaggedArray);
        }

        static int MinValueJaggedArray(int[][] arr)
        {
            int min = arr[0][0];
            int minRow = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] <= min)
                    {
                        min = arr[i][j];
                        minRow = i;
                    }
                }
            }
            return minRow;
        }

        static int[][] AddRowAfterMinValue(int[][] arr)
        {
            int minRow = MinValueJaggedArray(arr);
            Console.WriteLine($"Мінімальний елемент масиву знаходиться в рядку {minRow + 1}");

            int[][] newArr = new int[arr.Length + 1][];
            for (int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                newArr[j] = arr[i];
                if (i == minRow)
                {
                    Console.WriteLine("Заповнення нового рядка...");
                    newArr[++j] = ArrayMy.FillArray();
                }
            }

            return newArr;
        }

        static void AddRowAfterMinValueResize(ref int[][] arr)
        {
            int minRow = MinValueJaggedArray(arr);
            Console.WriteLine($"Мінімальний елемент масиву знаходиться в рядку {minRow + 1}");

            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > minRow + 1; i--)
            {
                arr[i] = arr[i - 1];
            }

            Console.WriteLine("Заповнення нового рядка...");
            arr[minRow + 1] = ArrayMy.FillArray();
        }

        static int[][] AddRowAfterMinValueList(int[][] arr)
        {
            int minRow = MinValueJaggedArray(arr);
            Console.WriteLine($"Мінімальний елемент масиву знаходиться в рядку {minRow + 1}");

            List<int[]> newList = new List<int[]>(arr);
            Console.WriteLine("Заповнення нового рядка...");
            newList.Insert(minRow + 1, ArrayMy.FillArray());

            return newList.ToArray();
        }
    }
}
