using System;
using System.Text;
using array;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zalata
{
    public class variant2and13
    {
        public static void Variant2(ref int[] myArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 2 - Знищити останній від’ємний елемент.");
            //arrayHelper.PrintArray(myArray);
            myArray = DestroyLastElement(myArray);
            ArrayMy.PrintArray(myArray);
        }

        static int FindLastElement(int[] arr)
        {
            int lastMinus = -1;
            bool flak = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    lastMinus = i;
                    flak = false;
                }

            }
            if (flak)
            {
                Console.WriteLine("Не було знайдено від'ємних елементів. Масив залишився без змін.");
            }
            return lastMinus;
        }

        static int[] DestroyLastElement(int[] arr)
        {
            int lastMinus = FindLastElement(arr);
            if (lastMinus == -1)
            {
                 return arr;
            }
            int[] newArr = new int[arr.Length - 1];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != lastMinus)
                {
                    newArr[index++] = arr[i];
                }
            }
            return newArr;
        }

        public static void Variant13(ref int[][] myJaggedArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 13 - Додати рядок перед рядком, що містить мінімальний елемент.");
            //int[][] myJaggedArray = arrayJaggedHelper.FillJaggedArray();
            int minindex = minRow(myJaggedArray);
            myJaggedArray = JaggedArray.AddRowBeforeMaxOrMinValue(myJaggedArray, minindex);
            JaggedArray.PrintJaggedArray(myJaggedArray);


        }

        static int minRow(int[][] arr)
        {
            int minElement = int.MaxValue;
            int row = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < minElement)
                    {
                        minElement = arr[i][j];
                        row = i;
                    }
                }
            }
            return row;
        }

    }
}
