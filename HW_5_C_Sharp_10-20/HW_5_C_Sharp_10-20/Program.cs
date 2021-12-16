using System;

namespace HW_5_C_Sharp_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //______________________________________________________________________
            //Задание 10
            //Дан одномерный массив размера n, заполнить его случайными числами.
            //Найти и вывести в консоль все нечётные элементы массива и их индексы.
            //n вводит пользователь


            //Console.Write("Enter number 1: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 1: ");
            //}
            //int[] mass = new int[n];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    mass[i] = rand.Next(10, 100);
            //    Console.WriteLine(mass[i]);
            //}
            //Console.WriteLine("\nAll odd array elements and their index number: ");
            //for (int i = 0; i < n; i++)
            //{
            //    if (mass[i] % 2 == 1)
            //    {
            //        Console.WriteLine(mass[i] + " index " + i);
            //    }
            //}





            //_________________________________________________________________________________________________________
            //Задание 11
            //Дан двумерный массив размера n* n, заполнить его случайными числами в диапазоне - 99...99(включительно).
            //Поменять знак каждого элемента массива, кроме 0.
            //n вводит пользователь


            //Console.Write("Enter number: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number: ");
            //}

            //int[,] mass = new int[n, n];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n; j++)
            //    {
            //        mass[i, j] = rand.Next(-99, 99);
            //        Console.Write(mass[i, j] + " ");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (mass[i, j] != 0)
            //        {
            //            mass[i, j] = mass[i, j] * -1;
            //            Console.Write(mass[i, j] + " ");
            //        }
            //    }
            //}





            //_______________________________________________________________________________________________
            //Задание 12
            //Создать двумерный массив n*m, размер массива вводит пользователь,
            //затем заполнить массив рандомно значениями в диапазоне от 10 до 40.
            //Заменить все элементы массива с четными значениями на значение, которое введет пользователь.


            //Console.Write("Enter number n: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number n: ");
            //}
            //Console.Write("Enter number m: ");
            //int m;
            //while (!int.TryParse(Console.ReadLine(), out m))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number m: ");
            //}

            //int[,] mass = new int[n, m];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < m; j++)
            //    {
            //        mass[i, j] = rand.Next(10, 40);
            //        Console.Write(mass[i, j] + " ");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //int check;
            //Console.Write("Enter the number: ");
            //while (!int.TryParse(Console.ReadLine(), out check))
            //{
            //    Console.WriteLine("Enter the number please");
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (mass[i, j] % 2 == 0)
            //        {
            //            mass[i, j] = check;
            //        }
            //        Console.Write(mass[i, j] + " ");
            //    }
            //}





            //__________________________________________________________________________________
            //Задание 13
            //Создать квадратную матрицу, размер вводит пользователь,
            //затем заполнить массив рандомно значениями в диапазоне от -20 до 20.
            //Поменять местами элементы главной и побочной диагоналей.
            //Вычислить суммы элементов главной и побочной диагоналей.


            //Console.Write("Enter number: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number: ");
            //}

            //int[,] mass = new int[n, n];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = 0; j < n; j++)
            //    {
            //        mass[i, j] = rand.Next(-20, 20);
            //        Console.Write(mass[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int sum1 = 0; int sum2 = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            int box;
            //            box = mass[i, j];
            //            mass[i, j] = mass[i, n - j - 1];
            //            mass[i, n - j - 1] = box;
            //            sum1 = sum1 + mass[i, j];
            //            sum2 = sum2 + mass[i, n - j - 1];
            //        }
            //    }Console.WriteLine();

            //}

            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(mass[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine($"The sum of the elements of the main matrix: {sum1}");
            //Console.WriteLine($"The sum of the elements of the side diagonals: {sum2}");





            //_______________________________________________________________________________________________
            //Задание 14
            //Создать одномерный массив из 20 элементов. Заполнить рандомно от 0 до 10.
            //Преобразовать его в двумерный массив 4х5.
            //Поменять местами первую строку со второй и третью с четвертой.


            //int[] arr = new int[20];
            //int[,] matrix = new int[4, 5];
            //int arrCounter = 0;
            //Random rand = new Random();

            //for (int i = 0; i < 20; i++)
            //{
            //    arr[i] = rand.Next(0, 10);
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine("\n");

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        matrix[i, j] = arr[arrCounter++];
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //int tempBox = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    tempBox = matrix[0, i];
            //    matrix[0, i] = matrix[1, i];
            //    matrix[1, i] = tempBox;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    tempBox = matrix[2, i];
            //    matrix[2, i] = matrix[3, i];
            //    matrix[3, i] = tempBox;
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();





            //_______________________________________________________________________________________________
            //Задание 15
            //Создать программу, которая делит одно целое число на другое целое число,
            //и если результат - целое число - возвращает его пользователю,
            //если нет - сообщает о том, что деление невозможно.
            //Числа вводит пользователь.


            //Console.Write("Input first integer: ");
            //int number1;
            //while (!int.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("Please enter an integer");
            //    Console.Write("Input first integer: ");
            //}

            //Console.Write("Input second integer: ");
            //int number2;
            //while (!int.TryParse(Console.ReadLine(), out number2) || number2 == 0)
            //{
            //    Console.WriteLine("Please enter an integer");
            //    Console.Write("Input second integer: ");
            //}

            //int result = number1 / number2;
            //if (number1 % number2 == 0)
            //{
            //    Console.WriteLine($"Here is the result: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Division is impossible");
            //}





            //_______________________________________________________________________________________________
            //Задание 16
            //Создать два двумерных массива. Размеры задает пользователь.
            //Заполнить рандомными значениями от 10 до 50.
            //Вывести в консоль элементы, которые есть в обоих массивах, так же вывести их индексы.


            //Console.Write("Enter number n: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number n: ");
            //}
            //Console.Write("Enter number m: ");
            //int m;
            //while (!int.TryParse(Console.ReadLine(), out m))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number m: ");
            //}
            //int[,] mass1 = new int[n, m];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = 0; j < m; j++)
            //    {
            //        mass1[i, j] = rand.Next(10, 50);
            //        Console.Write(mass1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.Write("Enter number n2: ");
            //int n2;
            //while (!int.TryParse(Console.ReadLine(), out n2))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number n1: ");
            //}
            //Console.Write("Enter number m2: ");
            //int m2;
            //while (!int.TryParse(Console.ReadLine(), out m2))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number m2: ");
            //}

            //int[,] mass2 = new int[n2, m2];
            //for (int i = 0; i < n2; i++)
            //{

            //    for (int j = 0; j < m2; j++)
            //    {
            //        mass2[i, j] = rand.Next(10, 50);
            //        Console.Write(mass2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //int counter = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        for(int i1 = 0; i1 < n2; i1++)
            //        {
            //            for(int j2 = 0; j2 < m2; j2++)
            //            {
            //                if(mass1[i,j] == mass2[i1, j2])
            //                {
            //                    Console.WriteLine($"\t{mass1[i, j]} index {i} and {j}");
            //                    counter++;
            //                }
            //            }
            //        }
            //    }
            //}
            //if(counter == 0)
            //{
            //    Console.WriteLine("No common elements");
            //}





            //_______________________________________________________________________________________________
            //Задание 17
            //“Перевернуть” двумерный массив. Условие: строки должны стать столбцами, и наоборот

            //Console.Write("Enter number: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number: ");
            //}

            //int[,] mass = new int[n, n];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n; j++)
            //    {
            //        mass[i, j] = rand.Next(-99, 99);
            //        Console.Write(mass[i, j] + " ");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //int[,] massReverse = new int[n,n];
            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n; j++)
            //    {
            //        massReverse[i, j] = mass[j, i];
            //        Console.Write(massReverse[i, j] + " ");
            //    }
            //}





            //_______________________________________________________________________________________________
            //Задание 18 && Задание 19
            //Подсчитать среднее арифметическое двумерного массива. Размер массива вводится из консоли.

            //Console.Write("Enter number n: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number n: ");
            //}
            //Console.Write("Enter number m: ");
            //int m;
            //while (!int.TryParse(Console.ReadLine(), out m))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number m: ");
            //}
            //int tempBox = 0;

            //int[,] mass = new int[n, m];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < m; j++)
            //    {
            //        mass[i, j] = rand.Next(10, 90);
            //        Console.Write(mass[i, j] + " ");
            //        tempBox += mass[i, j];
            //    }
            //}
            //Console.WriteLine("\n\n\tArithmetic mean of a two - dimensional array: " + tempBox / (n * m));





            //_______________________________________________________________________________________________
            //Задание 20
            //Написать программу калькулятор,
            //программа должна уметь прибавлять, вычитать, умножать, делить и находить остаток от деления.

            //double num1; double num2;

            //Console.WriteLine("Console Calculator in C#\r");
            //Console.WriteLine("------------------------\n");

            //Console.Write("Enter the number 1: ");
            //while (!double.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 1: ");
            //}
            //Console.Write("Enter the number 2: ");
            //while (!double.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 2: ");

            //}

            //Console.WriteLine("Choose an option from the following list:");
            //Console.WriteLine("\ta - Add");
            //Console.WriteLine("\ts - Subtract");
            //Console.WriteLine("\tm - Multiply");
            //Console.WriteLine("\td - Divide");
            //Console.WriteLine("\tf - Find the remainder of the division");
            //Console.Write("Your option? ");

            //switch (Console.ReadLine())
            //{
            //    case "a":
            //        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            //        break;
            //    case "s":
            //        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            //        break;
            //    case "m":
            //        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            //        break;
            //    case "d":
            //        while (num2 == 0)
            //        {
            //            Console.Write("Enter a non-zero divisor: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //        }
            //        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            //        break;
            //    case "f":
            //        Console.WriteLine($"Your result: {num1} % {num2} = " + (num1 % num2));
            //        break;
            //}
        }
    }
}
