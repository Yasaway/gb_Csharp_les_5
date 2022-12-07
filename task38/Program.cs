// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void packArray(double[] array)
{
    Random rnd = new Random();
    Random rndInt = new Random();
    for (int i = 0; i < array.Length; i++) {array[i] = Math.Round(Convert.ToDouble(rndInt.Next(-100,100)-rnd.NextDouble()),2);}
}

void printArray(double[] array)
{
    Console.Write("Массив ");
    for (int i = 0; i < array.Length; i++) {Console.Write(array[i] + " ");}
    Console.WriteLine();
}

double minArray(double[] array)
{
    double min = array[0];    
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] < min) {min = array[i];}
    }
    Console.WriteLine("Минимальный элемент массива равен " + min);
    return min;
}

double maxArray(double[] array)
{
    double max = array[0];    
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max) {max = array[i];}
    }
    Console.WriteLine("Максимальный элемент массива равен " + max);
    return max;
}

void oddsArray(double min, double max)
{
    double odds = 0.0;    
    odds = Math.Round(max - min,2);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + odds);
}
 
Console.WriteLine("Программа находит разницу между максимальным и минимальным элементами массива ");
int lengthMass = 5;
double[] array = new double[lengthMass];
packArray(array);
printArray(array);
oddsArray(minArray(array), maxArray(array));