Console.Clear();

Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.Write("!! Введённые позиции не могут быть меньше 1 !!");
    return;
}
int [,] numbers = new int [5,5];

void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(10);
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
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Console.WriteLine("Результат формирования двумерного массива: ");
RandomNumbersArray(numbers);
WriteArray(numbers);

if (m > numbers.GetLength(0) || n > numbers.GetLength(0))
{
    Console.WriteLine($"Числа на позиции строки {m} и столбца {n} - Нет!");
}
else
{
    Console.WriteLine($"Число на позиции строки {m} и столбца {n} = {numbers[m-1,n-1]}");
}