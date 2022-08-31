Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.Write("!! Размер строки или столбцов двумерного массива не может быть меньше 1 !!");
    return;
}
int[,] numbers = new int[m, n];

void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void WriteArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Результат формирования двумерного массива: ");
RandomNumbersArray(numbers);
WriteArray(numbers);


Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < numbers.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        sum = (sum + numbers[j, i]);
    }
    sum = sum / m;
    Console.Write($"{sum}; ");
}