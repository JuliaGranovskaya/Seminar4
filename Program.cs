// Принять на вход число A и выдать сумму чисел от 1 до A
// int sumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// for (int i = 0; i < 5; i++)
// {
//     Console.Write("Введите число: ");
//     int A = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Сумма чисел от 1 до {A}: {sumNumbers(A)}");
// }

// Вывести массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// int[] GenerateRandomArray(int N)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next();
//     }
//     return RandomArray;
// }
// int[] GenerateArray(int N)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент массивa");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +" ");
//  }   
//     Console.WriteLine();
// }
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = GenerateRandomArray(num, min, max);
// ShowArray(myArray);

// int[] myArray = GenerateRandomArray(num);
// ShowArray(myArray);

// Домашнее задание

// Цикл, который принимает на вход 2 числа (A и B) и возводит число A в натуральную степень B.
// int NumberDegree(int number1, int number2)
// {
//     int degree = 1;
//     for (int i = 1; i <= number2; i++)
//     {
//         degree = degree*number1;
//     }
//     return degree;
// }
// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{A}, {B} -> {NumberDegree(A, B)}");

// Принимает число и выдает сумму цифр в числе
// int SumNumbers(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} -> {SumNumbers(number)}");

// Программа создает массив из 8 элементов и выводит их на экран
// int [] FillArray(int N, int start, int end)
// {
//     int [] collection = new int[N];
//     int index = 0;
//     while (index < N)
//     {
//         collection[index] = new Random().Next(start, end + 1);
//         index++;
//     }
//     return collection;
// }

// void PrintArray(int [] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] +" ");
//         position++;
//     }
// }
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = FillArray(num, min, max);
// PrintArray(myArray);

