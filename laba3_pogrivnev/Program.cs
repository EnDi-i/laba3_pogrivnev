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
            int[] Array = null;
            int[][] JaggedArr = null;
            do
            {
                Console.WriteLine("Виберіть Блок(1/2) Для завершення - 0");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Блок 1");

                        Block1(ref Array);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Блок 2");
                        
                        Block2(ref JaggedArr);
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

        static void Block1(ref int[] Array)
        {
            if (Array == null)
            {
                Console.WriteLine("Заповніть масив");
                Array = ArrayMy.FillArray();
                Console.WriteLine();
                ArrayMy.PrintArray(Array);
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
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 2 - Залата");
                        ArrayMy.PrintArray(Array);
                        variant2and13.Variant2(ref Array);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 8 - Голтвянський");
                        ArrayMy.PrintArray(Array);
                        Varianti8_14.Variant8(ref Array);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 9 - Сидоренко");
                        ArrayMy.PrintArray(Array);
                        Varianti9_12.Variant9(ref Array);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Блок 1. Варіант 16 - Кононенко");
                        ArrayMy.PrintArray(Array);
                        Varianti16_6.Variant16(ref Array);
                        break;
                    case 5:
                        Console.WriteLine("Стан масиву");
                        ArrayMy.PrintArray(Array);
                        break;
                    case 6:
                        Console.WriteLine("Заповніть масив");
                        Array = ArrayMy.FillArray();
                        ArrayMy.PrintArray(Array);
                        break;
                    case 0:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Виберіть варіант від 1 до 6, для виходу - 0");
                        break;
                }
            } while (choice != 0);
        }

        static void Block2(ref int[][] JaggedArr)
        {
            if (JaggedArr == null)
            {
                Console.WriteLine("Заповніть зубчастий масив");
                JaggedArr = JaggedArray.FillJaggedArray();
                Console.WriteLine();
                JaggedArray.PrintJaggedArray(JaggedArr);
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
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 6 - Кононенко");
                        JaggedArray.PrintJaggedArray(JaggedArr);
                        Varianti16_6.Variant6(ref JaggedArr);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 12 - Сидоренко");
                        JaggedArray.PrintJaggedArray(JaggedArr);
                        Varianti9_12.Variant12(ref JaggedArr);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 13 - Залата");
                        JaggedArray.PrintJaggedArray(JaggedArr);
                        variant2and13.Variant13(ref JaggedArr);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Блок 2. Варіант 14 - Голтвянський");
                        JaggedArray.PrintJaggedArray(JaggedArr);
                        Varianti8_14.Variant14(ref JaggedArr);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Стан зубчастого масиву");
                        JaggedArray.PrintJaggedArray(JaggedArr);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Заповніть зубчастий масив");
                        JaggedArr = JaggedArray.FillJaggedArray();
                        break;
                    case 0:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Виберіть варіант від 1 до 6, для виходу - 0");
                        break;
                }
            } while (choice != 0);
        }
    }
}
