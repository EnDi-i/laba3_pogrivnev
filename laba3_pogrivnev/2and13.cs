using System;
using System.Text;
using array;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zalata
{
    public class variant2and13
    {
        public void Variant2(int[] myArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 2 - Знищити останній від’ємний елемент.");
            ArrayMy arrayHelper = new ArrayMy();
            myArray = DestroyLastElement(myArray);
            arrayHelper.PrintArray(myArray);
        }

        static int FindLastElement(int[] arr)
        {
            int lastMinus = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    lastMinus = i;
                }
                else
                {
                    Console.WriteLine("Введений масив не має від'ємних чисел");
                }
            }
            return lastMinus;
        }

        static int[] DestroyLastElement(int[] arr)
        {
            int lastMinus = FindLastElement(arr);
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


    }
}