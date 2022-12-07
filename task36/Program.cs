// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void packArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) {array[i] = rnd.Next(0, 100);}
}

void printArray(int[] array)
{
    Console.Write("Массив ");
    for (int i = 0; i < array.Length; i++) {Console.Write(array[i] + " ");}
    Console.WriteLine();
}

void notEvenArray(int[] array)
{
    int summNotEven = 0;
    for (int i = 0; i < array.Length; i++) {if (i != 0 && i % 2 != 0) summNotEven = summNotEven + array[i]; };
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна " + summNotEven);
}
 
Console.WriteLine("Программа показывает сумму элементов, стоящих на нечётных позициях в массиве");
int lengthMass = 4;
int[] array = new int[lengthMass];
packArray(array);
printArray(array);
notEvenArray(array);