// Задача 34. Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void packArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) {array[i] = rnd.Next(99, 1000);}
}

void printArray(int[] array)
{
    Console.Write("Массив ");
    for (int i = 0; i < array.Length; i++) {Console.Write(array[i] + " ");}
    Console.WriteLine();
}

void evenArray(int[] array)
{
    int chetn = 0;
    for (int i = 0; i < array.Length; i++) {if (array[i] % 2 == 0) chetn++;}
    Console.WriteLine("Количество чётных чисел в массиве " + chetn);
}
 
Console.WriteLine("Программа показывает количество чётных чисел в массиве ");
int lengthMass = 4;
int[] array = new int[lengthMass];
packArray(array);
printArray(array);
evenArray(array);