using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void num5()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

    }







    static void num6()
    {
        Console.WriteLine("Введите ширину прямоугольника:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите высоту прямоугольника:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("8");
            }
            Console.WriteLine();
        }
    }






    static void num7()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("8");
            }
            Console.WriteLine();
        }
    }



    static void num8()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("8");
        }
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("8");
        }
    }



    static void num9()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Я никогда не буду работать за копейки.");
        }
    }



    static void num10()
    {
        Console.WriteLine("Введите три числа:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int min = Math.Min(num1, Math.Min(num2, num3));
        int max = Math.Max(num1, Math.Max(num2, num3));

        int average = num1 + num2 + num3 - min - max;

        Console.WriteLine("Среднее число: " + average);
    }



    static void num11()
    {
        Console.WriteLine("Введите ваше имя:");
        string name = Console.ReadLine();

        Console.WriteLine("Введите дату вашего рождения в формате: день месяц год (например, 01 01 2000):");
        string[] birthDate = Console.ReadLine().Split(' ');
        int day = Convert.ToInt32(birthDate[0]);
        int month = Convert.ToInt32(birthDate[1]);
        int year = Convert.ToInt32(birthDate[2]);

        Console.WriteLine("Меня зовут " + name);
        Console.WriteLine("Я родился " + day + "." + month + "." + year);
    }



    static void num12()
    {
        string[] array = new string[10];
        Console.WriteLine("Введите 8 строк:");
        for (int i = 0; i < 8; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("Содержимое массива:");
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }



    static void num13()
    {
        int[] array = new int[10];

        Console.WriteLine("Введите 10 чисел:");

        // Ввод чисел с клавиатуры и сохранение их в массив
        for (int i = 0; i < 10; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Содержимое массива:");

        // Вывод всех элементов массива в обратном порядке
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }



    static void num14()
    {
        int[] bigArray = new int[20];
        int[] smallArray1 = new int[10];
        int[] smallArray2 = new int[10];
        Console.WriteLine("Введите 20 чисел:");
        for (int i = 0; i < 20; i++)
        {
            bigArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Copy(bigArray, 0, smallArray1, 0, 10);
        Array.Copy(bigArray, 10, smallArray2, 0, 10);

        Console.WriteLine("Второй маленький массив:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(smallArray2[i]);
        }
    }



    static void Num15()
    {
        int[] houseArray = new int[15];

        Console.WriteLine("Введите количество жителей в каждом доме:");

        // Ввод количества жителей с клавиатуры и сохранение их в массив
        for (int i = 0; i < 15; i++)
        {
            houseArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        int oddSum = 0;
        int evenSum = 0;

        // Подсчет суммы жителей в домах с нечетными и четными номерами
        for (int i = 0; i < 15; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += houseArray[i];
            }
            else
            {
                oddSum += houseArray[i];
            }
        }
    }
}
