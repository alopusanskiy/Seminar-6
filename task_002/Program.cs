// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindPoint(int[] arr)
{
    // double x = ((arr[2] - arr[0]) / (arr[1] - arr[3])); Почему-то так не работает, проходил отладчиком в VS - выражение возвращает 0,
    // не могу понять почему так.

    double x1 = arr[2] - arr[0];  // В таком варианте работает без проблем.
    double x2 = arr[1] - arr[3];
    double x3 = x1 / x2;

    double pointFirst = (arr[1] * x3) + arr[0];
    double pointSecond = (arr[3] * x3) + arr[2];

    System.Console.Write("-> " + pointFirst + " ");
    System.Console.WriteLine(pointSecond);

}

int[] array = new int[4];

System.Console.WriteLine("Введите значение переменной b1: ");
array[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение переменной k1: ");
array[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение переменной b2: ");
array[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение переменной k2: ");
array[3] = Convert.ToInt32(Console.ReadLine());

FindPoint(array);