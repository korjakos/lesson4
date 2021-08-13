using System;

namespace ex1
{

    class Class1
    {
        static int[] mass = new int[20];
        static int count = 0;
        static Random random = new Random();
        //Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        //Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива,
        //в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива
        // Нурумов Олжас
        static void set_num()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-10000, 10000);
                Console.Write(mass[i] + ", ");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void search()
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i] % 3 == 0 && mass[i + 1] % 3 == 0) { }
                else
                {
                    if (mass[i] % 3 != 0 && mass[i + 1] % 3 != 0) { }
                    else
                    {
                        count++;
                        Console.WriteLine(mass[i] + ", " + mass[i + 1]);
                    }
                }
            }
        
    }
        class Program
        {
            static void Main(string[] args)
            {
                set_num();
                search();
                Console.WriteLine("Количиство пар равно: " + count);
            }
        }

        }
}
