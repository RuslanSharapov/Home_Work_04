/* Задать массив, заполнить случайными положительными трёхзначными числами.
Показать количество нечетных\четных чисел */

int[] array = new int[10];
int evenNumbers = 0;
int notEvenNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 120);
    Console.Write(array[i] +" ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    {
        evenNumbers++;
    }

    else
    {
        notEvenNumbers++;
    }
}
Console.Write($"Количество четных чисел массива: {evenNumbers}");
Console.WriteLine();
Console.Write($"Количество нечетные чисел массива: {notEvenNumbers}");