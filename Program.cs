/*
int Calculate(int a, int b, char sing)
{
    int result = 0;
    if (sing =='+')
    {
        result = a +b;
    }
    else if (sing == '-')
    result = a -b;
else
{
Console.WriteLine("Такого знака еще нет");
}
return result;
}
*/
/*
int[] GetArray (int size, int minValue, int maxVale)
{
    int[] resultArray = new int[size];
    for(int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxVale+1);
    }
    return resultArray;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
int posetiveSum = 0;
int negativSum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        posetiveSum = posetiveSum + array[i];
    }
    else
    {
        negativSum = negativSum + array[i];
    }
}
Console.WriteLine($"Сумм пол {posetiveSum}, отр: {negativSum}");


int[] InverseArray (int[] arr)

    for (int= 0; int < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
    return arr;
*/


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
        evenNumbers=evenNumbers+1;
    }
    
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] четных чесел в массиве = {evenNumbers}");
