/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Случайный массив: ");
PrintArray(numbers);
int count = 0;

for (int n = 0; n < numbers.Length; n++)
    if (numbers[n] % 2 == 0)
        count++;
Console.WriteLine($"Всего в массиве чётных чисел: {count}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,1000);
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
