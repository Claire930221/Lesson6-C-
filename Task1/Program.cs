/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int PositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sum++;
    }
    return sum;
}
Console.WriteLine("Введите числа через пробел");
var str = Console.ReadLine() ?? "";
int[] array = Array.ConvertAll(str.Split(' '), int.Parse);
Console.WriteLine("Количество чисел больше 0 в заданном массиве" + " " + PositiveNumbers(array));