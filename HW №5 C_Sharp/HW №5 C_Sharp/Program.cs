using System;

namespace HW__5_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////___________________________________________________________
            ////Задание 1
            ////Вывести наибольшее из трех чисел.
            ////Числа вводит пользователь

            //int number1, number2, number3;
            //Console.Write("Enter number 1: ");
            //while (!int.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 1: ");
            //}
            //Console.Write("Enter number 2: ");
            //while (!int.TryParse(Console.ReadLine(), out number2))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 2: ");
            //}
            //Console.Write("Enter number 3: ");
            //while (!int.TryParse(Console.ReadLine(), out number3))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 3: ");
            //}

            //int maxNumber = number1;

            //if (number2 >= maxNumber)
            //{
            //    maxNumber = number2;
            //}
            //if (number3 >= maxNumber)
            //{
            //    maxNumber = number3;
            //}

            //Console.WriteLine($"\nThe largest of three numbers: {maxNumber}");




            ////____________________________________________________________________
            ////Задание 2
            ////Посчитать сумму цифр в трехзначном числе
            ////Число вводит пользователь

            //int a;
            //while (true)
            //{
            //    Console.Write("Enter a three-digit number: ");
            //    while (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        Console.WriteLine("Enter the number please");
            //        Console.Write("Enter a three-digit number: ");
            //    }

            //    if (a > 99 && a < 1000)
            //    {
            //        break;
            //    }
            //}

            //int[] arr = new int[3];
            //arr[0] = a % 10;
            //a = a / 10;
            //arr[1] = a % 10;
            //a = a / 10;
            //arr[2] = a;

            //int sum = arr[0] + arr[1] + arr[2];
            //Console.WriteLine($"\nSum of digits in a three-digit number: {sum}");



            ////______________________________________________________________________
            ////Задание 3
            ////Перевести метры в километры
            ////Метры вводит пользователь

            //Console.Write("Enter length in meters: ");
            //double number;
            //while(!double.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Enter the number please\n");
            //    Console.Write("Enter length in meters: ");
            //}

            //number = number / 1000;

            //Console.WriteLine($"\nIt turned out {number} kilometers" );



            ////_________________________________________________________________________
            ////Задание 4
            ////По введенному номеру дня неделе вывести его название,
            ////используя оператор множественного выбора
            ////Номер дня недели вводит пользователь

            //int day_of_week;
            //Console.Write("Enter the day of the week: ");
            //while (!int.TryParse(Console.ReadLine(), out day_of_week))
            //{
            //    Console.WriteLine("Enter the number please\n");
            //    Console.Write("Enter the day of the week: ");
            //}

            //switch (day_of_week)
            //{
            //    case 1:
            //        Console.WriteLine("Day of week: Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Day of week: Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Day of week: Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Day of week: Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Day of week: Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Day of week: Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Day of week: Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("There is no such day of the week");
            //        break;
            //}



            //____________________________________________________________________
            //Задание 5
            //Программа должна, в качестве входных данных,
            //принимать только пятизначные числа и определять,
            //является ли введенное пятизначное число палиндромом


            //Console.Write("Введите 5-и значное число: ");
            //int palindrom;
            //string num;
            //while (true)
            //{
            //    num = Console.ReadLine();
            //    palindrom = Convert.ToInt32(num);


            //    if (palindrom > 9999 && palindrom < 10000)
            //    {
            //        break;
            //    }

            //    char[] arr = new char[5];
            //    arr = num.ToCharArray();
            //    if (arr[0] == arr[4] && arr[1] == arr[3])
            //    {
            //        Console.WriteLine("This number is palindrome");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This number is not a palindrome");
            //    }

            //}




            //////_________________________________________________________________________
            //////Задание 6
            //////Используя оператор цикла do while, составить программу,
            //////которая будет требовать ввод цифр с клавиатуры до тех пор,
            //////пока не будет введена цифра 1.

            //int number;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //    while (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Enter the number please");
            //        Console.Write("Enter the number: ");
            //    }
            //} while (number != 1);




            ////___________________________________________________________________________
            ////Задание 7
            ////Разработать программу, которая будет выводить таблицу умножения
            ////для введенного пользователем числа с клавиатуры.

            //int number;
            //Console.Write("Enter the number: ");
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter the number: ");
            //}
            //for(int i = 1; i<11; i++)
            //{
            //    Console.WriteLine(i+ "*" + number + "=" + i*number);
            //}



            ////_______________________________________________________________________________________________________________
            ////Задание 8
            ////Напишите программу, чтобы проверить, находятся ли три заданных целых числа в диапазоне 50..99 (включительно).
            ////Верните true, если одно или несколько из них находятся в указанном диапазоне.
            ////Числа вводит пользователь

            //int number1, number2, number3;
            //Console.Write("Enter number 1: ");
            //while (!int.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 1: ");
            //}
            //Console.Write("Enter number 2: ");
            //while (!int.TryParse(Console.ReadLine(), out number2))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 2: ");
            //}
            //Console.Write("Enter number 3: ");
            //while (!int.TryParse(Console.ReadLine(), out number3))
            //{
            //    Console.WriteLine("Enter the number please");
            //    Console.Write("Enter number 3: ");
            //}

            //bool check = false;

            //if(number1 >= 50 && number1 <= 99)
            //{
            //    check = true;
            //}
            //if (number2 >= 50 && number3 <= 99)
            //{
            //    check = true;
            //}
            //if (number3 >= 50 && number3 <= 99)
            //{
            //    check = true;
            //}

            //Console.WriteLine(check);




            ////_________________________________________________________________
            ////Задание 9
            ////Найти самое длинное слово из четырех
            ////Слова вводит пользователь

            //Console.Write("Enter the first word: ");
            //string word1 = Console.ReadLine();
            //Console.Write("Enter the second word: ");
            //string word2 = Console.ReadLine();
            //Console.Write("Enter the third word: ");
            //string word3 = Console.ReadLine();
            //Console.Write("Enter the fourth word: ");
            //string word4 = Console.ReadLine();

            //int max = word1.Length;
            //string answer = "First word";

            //if(word2.Length >= max)
            //{
            //    max = word2.Length;
            //    answer = "Second word";
            //}

            //if (word3.Length >= max)
            //{
            //    max = word3.Length;
            //    answer = "Third word";
            //}

            //if (word4.Length >= max)
            //{
            //    max = word4.Length;
            //    answer = "Fourth word";
            //}

            //Console.WriteLine($"\nLongest word of four: {answer}");
        }
    }
}
