using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(' ');

        string[] newArray = FilterArrayByLength(originalArray);

        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    private static string[] FilterArrayByLength(string[] originalArray)
    {
        throw new NotImplementedException();
    }
}
