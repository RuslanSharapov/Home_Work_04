/* Найти произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. */

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    Console.Write($" {array[i] * array[j]} ");
    j--;
}