// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



// Заполняем масив случайными числами
int[] ComplArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(100,1000);
        index++;
    }
    return col;
}

// Проверка элемента массива на чётность
int ParityChecker(int[] col)
{
    int count = col.Length;
    int position = 0;
    int number=0;
        while (position < count)
    {
        if (col[position]%2==0)      // Проверяю, является ли элемент чётным
        {
            number++;
        }
        position++;
    }
    return number;   
}


////////////////////////////////////////
//Для наглядности и проверки работы введёна распечатка массива.

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position != (count-1))      // Проверяю, является ли элемент последним для печати без запятой
        {
        Console.Write($" {col[position]},");
        }
         else
        {
            Console.Write($" {col[position]}");
        }
        position++;
    }
    Console.WriteLine(" ]");    
}
////////////////////////////////////////


// Основная программа

// Задаём размер массива

int n = 0;
    try
    {
        Console.Write("Введите размер массива: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }



// Создаём новый массив длиной n
int[] array = new int[n];


int[] tempArray = ComplArray(array);
Console.WriteLine("");
Console.WriteLine("Введённый массив:");
PrintArray(tempArray);
Console.WriteLine($"Имеет {ParityChecker(tempArray)} чётных элемента");


