// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
int numberElement = 0;
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 200);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int j = 0; j < array.Length; j++)
{
    if(array[j] >= 10 && array[j] <= 99)
    {
        numberElement++;
    }
}
Console.WriteLine();
Console.Write($"Количество элементов из отрезка = {numberElement} ");