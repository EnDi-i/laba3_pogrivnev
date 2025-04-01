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
            //arrayHelper.PrintArray(myArray);
            myArray = DestroyLastElement(myArray);
            arrayHelper.PrintArray(myArray);
        }

        static int FindLastElement(int[] arr)
        {
            int lastMinus = 0;
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
                Console.WriteLine("Введений масив не має від'ємних чисел");
                
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

        public void Variant13(int[][] myJaggedArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 13 - Додати рядок перед рядком, що містить мінімальний елемент.");
            JaggedArray arrayJaggedHelper = new JaggedArray();
            //int[][] myJaggedArray = arrayJaggedHelper.FillJaggedArray();
            int minindex = minRow(myJaggedArray);
            myJaggedArray = arrayJaggedHelper.AddRowBeforeMaxOrMinValue(myJaggedArray, minindex);
            arrayJaggedHelper.PrintJaggedArray(myJaggedArray);


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