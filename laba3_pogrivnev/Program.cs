using System;
using System.Linq;
using System.Text;
using array;
using holtvanski;
using kononenko;
using sydorenko;
using zalata;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторна робота №3";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int choice;
            int[] initialArray = null;
            int[] variantArray = null;
            int[][] initialJaggedArr = null;
            int[][] variantJaggedArr = null;
            do
            {
                Console.WriteLine("Виберіть Блок(1/2) Для завершення - 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Блок 1");

                        Block1(ref initialArray, ref variantArray);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Блок 2");

                        Block2(ref initialJaggedArr, ref variantJaggedArr);
                        break;
                    case 0:
                        Console.WriteLine("Програма завершила роботу");
                        break;
                    default:
                        Console.WriteLine("Виберіть Блок 1 або 2, для завершення - 0");
                        break;
                }
            } while (choice != 0);
        }

        static void Block1(ref int[] initialArray, ref int[] variantArray)
        {
            if (initialArray == null)
            {
                Console.WriteLine("Заповніть масив");
                initialArray = ArrayMy.FillArray();
                variantArray = (int[])initialArray.Clone();
                Console.WriteLine();
                ArrayMy.PrintArray(initialArray);
            }
            int choice;
            do
            {
                Console.WriteLine(@"Виберіть варіант:
1. Варіант 2 - Залата
2. Варіант 8 - Голтвянський
3. Варіант 9 - Сидоренко
4. Варіант 16 - Кононенко

5. Перевірити стан масиву
6. Заповнити масив

0. Повернутися назад.
");
                choice = int.Parse(Console.ReadLine());
                int[] selectedArray = SelectArray(initialArray, variantArray);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 2 - Залата");
                        ArrayMy.PrintArray(selectedArray);
                        variant2and13.Variant2(ref selectedArray);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 8 - Голтвянський");
                        ArrayMy.PrintArray(selectedArray);
                        Varianti8_14.Variant8(ref selectedArray);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 9 - Сидоренко");
                        ArrayMy.PrintArray(selectedArray);
                        Varianti9_12.Variant9(ref selectedArray);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 16 - Кононенко");
                        ArrayMy.PrintArray(selectedArray);
                        Varianti16_6.Variant16(ref selectedArray);
                        break;
                    case 5:
                        Console.WriteLine("Стан масиву");
                        ArrayMy.PrintArray(selectedArray);
                        break;
                    case 6:
                        Console.WriteLine("Заповніть масив");
                        initialArray = ArrayMy.FillArray();
                        variantArray = (int[])initialArray.Clone();
                        ArrayMy.PrintArray(initialArray);
                        break;
                    case 0:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Виберіть варіант від 1 до 6, для виходу - 0");
                        break;
                }
                if (selectedArray == initialArray)
                {
                    initialArray = selectedArray;
                }
                else
                {
                    variantArray = selectedArray;
                }
            } while (choice != 0);
        }

        static void Block2(ref int[][] initialJaggedArr, ref int[][] variantJaggedArr)
        {
            if (initialJaggedArr == null)
            {
                Console.WriteLine("Заповніть зубчастий масив");
                initialJaggedArr = JaggedArray.FillJaggedArray();
                variantJaggedArr = CopyJaggedArray(initialJaggedArr);
                Console.WriteLine();
                JaggedArray.PrintJaggedArray(initialJaggedArr);
            }
            int choice;
            do
            {
                Console.WriteLine(@"Виберіть варіант:
1. Варіант 6 - Кононенко
2. Варіант 12 - Сидоренко
3. Варіант 13 - Залата
4. Варіант 14 - Голтвянський

5. Перевірити стан зубчастого масиву
6. Заповнити зубчастий масив

0. Повернутися назад.
");
                choice = int.Parse(Console.ReadLine());
                int[][] selectedJaggedArray = SelectJaggedArray(initialJaggedArr, variantJaggedArr);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 6 - Кононенко");
                        JaggedArray.PrintJaggedArray(selectedJaggedArray);
                        Varianti16_6.Variant6(ref selectedJaggedArray);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 12 - Сидоренко");
                        JaggedArray.PrintJaggedArray(selectedJaggedArray);
                        Varianti9_12.Variant12(ref selectedJaggedArray);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 13 - Залата");
                        JaggedArray.PrintJaggedArray(selectedJaggedArray);
                        variant2and13.Variant13(ref selectedJaggedArray);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 14 - Голтвянський");
                        JaggedArray.PrintJaggedArray(selectedJaggedArray);
                        Varianti8_14.Variant14(ref selectedJaggedArray);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Стан зубчастого масиву");
                        JaggedArray.PrintJaggedArray(selectedJaggedArray);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Заповніть зубчастий масив");
                        initialJaggedArr = JaggedArray.FillJaggedArray();
                        variantJaggedArr = CopyJaggedArray(initialJaggedArr);
                        break;
                    case 0:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Виберіть варіант від 1 до 6, для виходу - 0");
                        break;
                }
                if (selectedJaggedArray == initialJaggedArr)
                {
                    initialJaggedArr = selectedJaggedArray;
                }
                else
                {
                    variantJaggedArr = selectedJaggedArray;
                }
            } while (choice != 0);
        }

        static int[] SelectArray(int[] initialArray, int[] variantArray)
        {
            Console.WriteLine("Виберіть масив для використання (1 - початковий, 2 - варіант):");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return initialArray;
                case 2:
                    return variantArray;
                default:
                    Console.WriteLine("Невірний вибір, використовується початковий масив.");
                    return initialArray;
            }
        }

        static int[][] SelectJaggedArray(int[][] initialJaggedArray, int[][] variantJaggedArray)
        {
            Console.WriteLine("Виберіть зубчастий масив для використання (1 - початковий, 2 - варіант):");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return initialJaggedArray;
                case 2:
                    return variantJaggedArray;
                default:
                    Console.WriteLine("Невірний вибір, використовується початковий зубчастий масив.");
                    return initialJaggedArray;
            }
        }

        static int[][] CopyJaggedArray(int[][] source)
        {
            int[][] copy = new int[source.Length][];
            for (int i = 0; i < source.Length; i++)
            {
                copy[i] = new int[source[i].Length];
                Array.Copy(source[i], copy[i], source[i].Length);
            }
            return copy;
        }
    }

}
