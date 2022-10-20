/* Задать массив из 12 элементов, заполненных числами из [0,9].
Найти сумму положительных/отрицательных элементов массива */

int[] array = new int[12]; // Тут я не понял как можно сделать массив из [0, 9] с отрицательным значением !
int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-6, 6);
    Console.WriteLine(array[i]);
    if (array[i] >= 0)
    {
        sumPositive = array[i] + sumPositive;
    }
    else
    {
        sumNegative = array[i] + sumNegative;
    }
}
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");