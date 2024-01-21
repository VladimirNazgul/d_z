/*
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
using System.Runtime.InteropServices;

int Sum(int value)
{
    int result = 0;
    result += value % 10;
    value /= 10;
    if (value > 0)
    {
        result += Sum(value);
    }
    return result;
}
bool SumIsEven (int value)
{
    bool res = false;
    if (Sum(value) % 2 == 0)
    {
        res = true;
        Console.Write("сумма цифр чётная");
    }
    return res;
    
}

// void ThisALetter (string letter)
// {
//     if (letter == "q")
//     {
//         break;;
//     }
//     else SumIsEven (Convert.ToInt32(letter));

// }
while (true) //вечный цикл
{
    Console.WriteLine("Введите число :"); 
    string input = Console.ReadLine();
    if (input == "q") // проверяем на ввод буквы q (для выхода)
        break; //Выходим из вечного цикла
    int number = int.Parse(input);
    if (SumIsEven (number)) //Проверяем на четность сумму цифр
        break; //Выходим из вечного цикла
}
*/

/*
//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateArray (int sizen) 
{
    int [] createArray = new int [sizen];
    Random rnd = new Random();
    for (int i = 0; i < sizen; i++)
    {
        createArray[i] = rnd.Next(100, 1000);
    }
    return createArray;
}
void ShowArray (int [] arrayToShow)
{
    foreach(int val in arrayToShow)
    {
        Console.Write($"{val} ");
    }
    Console.WriteLine();
}

int CountOfEven (int [] array)
{
    int count = 0;
    foreach (int elm in array)
    {
        if (IsEven(elm))
            count++;
    }
    return count;
}
bool IsEven (int value)
{
    bool flag = false;
    if (value % 2 == 0)
    {
        flag = true;
    }
    return flag;
}
Console.Write("Ввести количество элементов массива: ");
int sizen = Convert.ToInt32(Console.ReadLine());
int [] arrayToShow = CreateArray(sizen);
ShowArray(arrayToShow);
Console.WriteLine($"Количество четных {CountOfEven(arrayToShow)}");
*/

/*
//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int [] CreateArray (int sizen) 
{
    int [] createArray = new int [sizen];
    Random rnd = new Random();
    for (int i = 0; i < sizen; i++)
    {
        createArray[i] = rnd.Next(0, 10);
    }
    return createArray;
}
void ShowArray (int [] arrayToShow)
{
    foreach(int val in arrayToShow)
    {
        Console.Write($"{val} ");
    }
    Console.WriteLine();
}

void ReverseOfArray (int[] array)
{
    for (int i = array.Length -1; i >= 0; i--)
    {
        Console.Write($"{array[i]} ");;
    }
    // for(int i = 0; i < array.Length/2; i++)
    // {
    //     int t = array[i];
    //     array[i] = array[array.Length-(i+1)];
    //     array[array.Length-(i+1)] = t;
 
    // }
    
    // for(int i = 0; i < array.Length/2; i++)
    // {
    //     (array[i], array[array.Length-(i+1)]) = (array[array.Length-(i+1)], array[i]); //обмен элементов
    // }
 
//Console.WriteLine(string.Join(" ", array));
}   
   
Console.Write("Ввести количество элементов массива: ");
int sizen = Convert.ToInt32(Console.ReadLine());
int [] arrayToShow = CreateArray(sizen);
ShowArray(arrayToShow);
Console.WriteLine("==>");
ReverseOfArray (arrayToShow);
*/