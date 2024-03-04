//Задача 1. Задайте массив из N случайных чисел (N вводится с
// клавиатуры). Найдите количество чисел, которые оканчиваются на 1 и
// делятся на цело на 7.
// Пример [1 5 11 21 81 4 0 91 2 3] => 2

// тип возв. значения/void + название функции + () + {}
// Название  + () - вызываем функцию где бы она не была

// Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// CompletionArray(); // вызываем функцию
// PrintArray();
// System.Console.WriteLine(FindCountNumber()); // печатаем результат функции в консоли

// void CompletionArray() // заполняет массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(20, 25);
//     }
// }

// void PrintArray() // печатает массив
// {
//     for (int i = 0; i < array.Length; i++) // вместо array.Length можно написать size
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// int FindCountNumber() // находит число нужных цифр
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++) // проходимся по всем эелементам массива
//     {
//         if (array[i] % 10 == 1 && array[i] % 7 == 0) // остаток от деления
//         // равен единице и делится на 7 без остатка
//         {
//             count = count + 1;
//             // count++
//         }
//     }
//     return count;
// }


// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// System.Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] СreateArray()
// {
// int [] array2 = new int[size];
// return array2;
// }
// int[] result= СreateArray();

// CompletionArray(result);
// PrintArray(result);

// Console.WriteLine(GetNumber(result));

// void CompletionArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i]= new Random().Next(0,10);
// }

// }

// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i]+ " ");
// }
// System.Console.WriteLine();
// }

// int GetNumber(int[] array)
// {
// string result="";

// for (int i = 0; i < array.Length; i++)
// {
// result =result+ array[i];
// }
// return Convert.ToInt32(result);
// }

