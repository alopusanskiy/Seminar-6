// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PrintArray(int[] arr)
{
    System.Console.Write("[" + string.Join(", ", arr) + "]");
}

void Iterator(int[] arr)
{
    int iterator = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            iterator++;
        }
    }
    System.Console.Write("-> " + iterator);
}


System.Console.Write("Введите список чисел через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

PrintArray(array);
Iterator(array);


