// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) 
    {
        sum += array[i];
    }
}
Console.WriteLine();
Console.Write($"Сумма чисел стоящих на нечетной позиции = {sum} ");