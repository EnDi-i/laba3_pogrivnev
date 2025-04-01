using System;
using System.Text;
using array;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace holtvanski
{
    public class Varianti8_14
    {
        public void Variant8(int[] myArray)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Варіант 8 - Знищити всі елементи з непарними індексами");
            if (myArray == null || myArray.Length == 0)
            {
                Console.WriteLine("Масив порожній або не ініціалізований.");
                return;
            }
            //myArray = arrayHelper.FillArray();

            myArray = RemoveOddIndexElements(myArray);
            //myArray = RemoveOddIndexElementsList(myArray);
            //RemoveOddIndexElementsResize(ref myArray);

            ArrayMy.PrintArray(myArray);

        }

        static int[] RemoveOddIndexElements(int[] arr)
        {
            

            int newSize = (arr.Length + 1) / 2;
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
            

            int newSize = (arr.Length + 1) / 2;
            int index = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                arr[index++] = arr[i];
            }

            Array.Resize(ref arr, newSize);
        }
        static int[] RemoveOddIndexElementsList(int[] arr)
        {
            
            List<int> newArr = new List<int>();
            for (int i = 1; i < arr.Length; i += 2)
            {
                newArr.Add(arr[i]);
            }
            return newArr.ToArray();
        }
        public void Variant14(int[][] myJaggedArray)
        {


            //int[][] myJaggedArray = arrayJaggedHelper.FillJaggedArray();
            Console.WriteLine("14. Додати рядок після рядка, що містить мінімальний елемент (якщо у різних місцях є кілька елементів з однаковим мінімальним значенням, то брати останній з них)");
            if (myJaggedArray == null || myJaggedArray.Length == 0)
            {
                Console.WriteLine("Зубчастий масив порожній або не ініціалізований.");
                return;
            }
            myJaggedArray = AddRowAfterMinValue(myJaggedArray);
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
                    Console.WriteLine("Зараз виконаємо заповння рядка, який буде доданий після рядка з останнім мінімальним елементом");
                    newArr[++j] = ArrayMy.FillArray(); 
                    
                }
            }
            return newArr;
        }


    }
}