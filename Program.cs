using System;

Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine();
string[] originalArray = input.Split(' ');

Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
