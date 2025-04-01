using System;
using System.Drawing;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace array
{
    public class ArrayMy
    {
        public int[] FillArray()
        {
            Console.WriteLine("Введіть розмір:");
            int size = SizeArray();

            int[] arr = new int[size];
            int choice;

            Console.WriteLine("Як ви хочите заповнити? (1 - випадковими числами, 2 - з клавіатури, 3 - кожен елемент з нового рядка)");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    arr = RandomArray(arr);
                    break;
                case 2:
                    arr = KeyboardArray(size);
                    break;
                case 3:
                    arr = NewLineArray(arr);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
            return arr;
        }
        public static int SizeArray()
        {
            int size;
            do
            {
                size = Convert.ToInt32(Console.ReadLine());
                if (size <= 0)
                {
                    Console.WriteLine("Розмір масиву повинен бути більшим за 0. Спробуйте ще раз.");
                }
            } while (size <= 0);
            return size;
        }

        static int[] RandomArray(int[] arr)
        {
            var (min, max) = MaxMinRand();

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

        public static (int min, int max) MaxMinRand() //тут використані кортежі
        {
            int max, min;
            do
            {
                Console.WriteLine("Введіть мінімальне число заповнення масиву:");
                min = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть максимальне число заповнення масиву:");
                max = Convert.ToInt32(Console.ReadLine());

                if (min > max)
                {
                    Console.WriteLine("Мінімальне число не може бути більше максимального. Спробуйте ще раз.");
                }
            } while (min > max);
            return (min, max);
        }

        static int[] KeyboardArray(int size)
        {
            Console.WriteLine($"Введіть {size} чисел через пробіл:");
            string? inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
            {
                Console.WriteLine("Помилка вводу. Спробуйте ще раз.");
                return KeyboardArray(size);
            }

            int[] input = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            if (input.Length != size)
            {
                Console.WriteLine($"Введено неправильна кількість чисел, а потрібно {size}. Спробуйте ще раз.");
                return KeyboardArray(size);
            }

            return input;
        }

        static int[] NewLineArray(int[] arr)
        {
            Console.WriteLine($"Введіть {arr.Length} чисел (кожен з нового рядка):");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Число {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public void PrintArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Масив не ініціалізований або порожній.");
                return;
            }


            Console.WriteLine("Масив:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    public class JaggedArray
    {
        public int[][] FillJaggedArray()
        {


            int choice;

            Console.WriteLine("Як ви бажаєте заповнити зубчастий масив? (1 - випадковими числами, 2 - з клавіатури)");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть кількість рядків для зубчастого масиву: ");
            int rows = ArrayMy.SizeArray();
            int[][] jaggedArray = new int[rows][];
            switch (choice)
            {
                case 1:
                    jaggedArray = RandomJaggedArray(jaggedArray);
                    break;
                case 2:
                    jaggedArray = InputJaggedArray(jaggedArray);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
            PrintJaggedArray(jaggedArray);
            return jaggedArray;
        }
        static int[][] InputJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Введіть елементи для {i + 1} рядка через пробіл: ");
                string? inputLine = Console.ReadLine();
                if (string.IsNullOrEmpty(inputLine))
                {
                    Console.WriteLine("Помилка вводу. Спробуйте ще один раз.");
                    i--;
                    continue;
                }

                jaggedArray[i] = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            return jaggedArray;
        }
        static int[][] RandomJaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("Як ви бажаєте встановити кількість елементів в рядку? (1-самостійно; 2-рандомно)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ColsInput(jaggedArray);
                    break;
                case 2:
                    ColsRandom(jaggedArray);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
            return jaggedArray;

        }
        static int[][] ColsRandom(int[][] jaggedArray)
        {
            Random rand = new Random();
            var (min, max) = ArrayMy.MaxMinRand();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[rand.Next(1, 11)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rand.Next(min, max);
                }
            }
            return jaggedArray;
        }
        static int[][] ColsInput(int[][] jaggedArray)
        {
            Random rand = new Random();
            var (min, max) = ArrayMy.MaxMinRand();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Введіть кількість елементів в {i + 1} рядку: ");
                jaggedArray[i] = new int[Convert.ToInt32(Console.ReadLine())];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rand.Next(min, max);
                }
            }
            return jaggedArray;
        }
        public void PrintJaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("Зубчастий масив:");
            foreach (int[] i in jaggedArray)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}