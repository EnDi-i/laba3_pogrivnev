using System;
using System.Text;
using array;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kononenko
{
    public class Varianti16_6
    {
        public static void Variant16(ref int[] myArray)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Варіант - 16, кожен елемент який йде перед парним замінити на 1 ");

            if (myArray.Length == 0)
            {
                Console.WriteLine("Масив пустий");
                return;
            }
            int couples = FindCouples(myArray);
            myArray = BiggerArray(myArray, couples);
            ArrayMy.PrintArray(myArray);
        }
        static int FindCouples(int[] arr)
        {
            int couples = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    couples++;
                }
            }
            return couples;
        }
        static int[] BiggerArray(int[] arr, int couples)
        {
            int[] newArr = new int[arr.Length + couples];
            int max = arr.Length - 1;
            for (int i = 0, index = 0; i < arr.Length; i++, index++)
            {
                if (arr[i] % 2 == 0)
                {
                    newArr[index++] = 1;
                }
                newArr[index] = arr[i];
            }
            return newArr;
        }
        public static void Variant6(ref int[][] myJagged)
        {
            Console.WriteLine("14.Знищити всі рядки, в яких є хоча б один елемент з нульовим значенням");
            if (myJagged == null || myJagged.Length == 0)
            {
                Console.WriteLine("Зубчастий масив порожній або не ініціалізований.");
                return;
            }
            myJagged = NewJaggedArraywithoutzero(myJagged);
            JaggedArray.PrintJaggedArray(myJagged);
        }
        static int DeleteRowsWithZero(int[][] myJaggedArray)
        {
            int count = 0;

            for (int i = 0; i < myJaggedArray.Length; i++)
            {
                bool hasZero = false;
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    if (myJaggedArray[i][j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }
                if (!hasZero) count++;
            }
            return count;
        }
            static int[][] NewJaggedArraywithoutzero(int[][] myJaggedArray)
            {
                int count = DeleteRowsWithZero(myJaggedArray);
                int[][] filteredArray = new int[count][];
                int index = 0;

                for (int i = 0; i < myJaggedArray.Length; i++)
                {
                    bool hasZero = false;
                    for (int j = 0; j < myJaggedArray[i].Length; j++)
                    {
                        if (myJaggedArray[i][j] == 0)
                        {
                            hasZero = true;
                            break;
                        }
                    }
                    if (!hasZero)
                    {
                        filteredArray[index++] = myJaggedArray[i];
                    }
                }

                return filteredArray;
            }
        
    }
}




