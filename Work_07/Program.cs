// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

int[] array = new int[10];
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.Write($"Разница = {(max - min)} ");