

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
int size =4;
int  minNuber = 100;
int maxNumber = 1000;
int evenNumbers = 0;

int[] array = new int [size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(minNuber, maxNumber);
    if (( array[i] % 2) == 0)
    {
        evenNumbers = evenNumbers + 1;
    }
    else
    {
        evenNumbers  =evenNumbers + 0;
    }
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] четных чисел в массиве = {evenNumbers}");


/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int size =4;
int  minNuber = -100;
int maxNumber = 101;
int sumEven = 0;

int[] array = new int [size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(minNuber, maxNumber);   
}

for (int i = 0; i < size; i = i + 2)
{
sumEven = sumEven + array[i];
}

Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] сумму элементов, стоящих на нечётных позициях = { sumEven}");
*/

/*
//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
int size =4;
double sumEven = 0;

double[] array = new double[size];
for (int i = 0; i < size; i++)
{

    array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    
      
}
double  minNumber = array[0];
double  maxNumber = array[0];
for (int i = 1; i < size; i++)
if (array[i] > maxNumber)
   {
    maxNumber = array[i];
   }
else{
    if (array[i] < minNumber )
    minNumber = array[i];
}
sumEven = maxNumber - minNumber;
sumEven = Math.Round(sumEven, 2);

Console.WriteLine($"Массив:  [ {String.Join("; ", array)} ] разница между максимальным и минимальным элементом массива = [{sumEven}] ");
*/