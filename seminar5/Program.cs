/*TASK1 Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Вариант А

int [] RandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

int Even (int [] array)  
 {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if(array[i] % 2 == 0)
         count++;
     }
     return count;
 }

int [] array = RandomArray (7, 100, 999);
ShowArray(array);
Console.Write($"The even elements of the array is {Even(array)}");*/

/* Вариант В

int [] RandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

bool is_even(int x)
{
    if(x%2==0) return true;
    return false;
}
int even_count(int [] a)
{
    int count=0;
    foreach (int x in a)
    {
        if(is_even(x)) count++;
    }
    return count;
}

int [] array = RandomArray (7, 100, 999);
ShowArray(array);
Console.Write($"The even elements of the array is {even_count(array)}"); */

/*TASK2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] RandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

int Odd (int [] array)  
 {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if(i % 2 == 1)
         count = count + array[i];
     }
     return count;
 }

int [] array = RandomArray (7, -10, 10);
ShowArray(array);
Console.Write($"The sum of odd elements is {Odd(array)}"); */

/*TASK3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] CreateArray (int size)
{
    int [] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i+1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

int Raznost (int [] array)
{
    int max=array[0], min=array[0];
    
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
        Console.WriteLine($"Max = {max}   Min = {min}");
    return max - min;   
}

int [] array = CreateArray (5);
ShowArray(array);
Console.Write($"The difference between the max and min elements of the array is {Raznost(array)}"); */

