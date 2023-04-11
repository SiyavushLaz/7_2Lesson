using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3; // количество строк
        int n = 4; // количество столбцов
        double[,] matrix = new double[m, n]; // создаем двумерный массив

        Random rnd = new Random(); // создаем экземпляр класса Random для генерации случайных чисел

        // заполняем двумерный массив случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.NextDouble() * 10; // генерируем случайное вещественное число от 0 до 10
            }
        }

        // выводим двумерный массив на консоль
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        // запрашиваем у пользователя позиции элемента в двумерном массиве
        Console.Write("Введите номер строки (от 0 до {0}): ", m - 1);
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введите номер столбца (от 0 до {0}): ", n - 1);
        int column = int.Parse(Console.ReadLine());

        // проверяем, существует ли элемент с указанными позициями
        if (row >= 0 && row < m && column >= 0 && column < n)
        {
            // если элемент существует, выводим его значение
            Console.WriteLine("Значение элемента [{0}, {1}]: {2}", row, column, matrix[row, column]);
        }
        else
        {
            // если элемент не существует, выводим сообщение об ошибке
            Console.WriteLine("Указанный элемент не существует");
        }
    }
}
