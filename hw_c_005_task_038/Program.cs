// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



// Заполняем масив случайными числами.
double[] ComplArray(double[] col)
{
    int length = col.Length;
    int index = 0;
    Random rand = new Random();
    while (index < length)
    {
        col[index] = rand.Next(-100, 100);;
        index++;
    }
    return col;
}

////////////////////////////////////////
//Для наглядности работы и проверки работы введёна распечатка массива.

void PrintArray(double[] col)
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


// Поиск разности между максимальным и минимальным элементами
double DiffMinMax(double[] col)

{
   int count = col.Length;
    int i = 0;
    Console.Write("");
    double minNumber=col[0];
    double maxNumber=col[0];
   while (i < count)
    {
        if (col[i]<minNumber)    // Ищем минимум в массиве
        {
            minNumber = col[i];
        }
         if (col[i]>maxNumber)    // Ищем максимум в массиве
        {
            maxNumber = col[i];
        }
        i++;
    }
    Console.WriteLine($"минимум: {minNumber}");
    Console.WriteLine($"максимум: {maxNumber}");
    return (maxNumber-minNumber);
}

//Основная программа

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
double[] array = new double[n];


double[] tempArray = ComplArray(array);
Console.WriteLine("Исходный массив");
PrintArray(tempArray);
Console.WriteLine($"Разность минимального и максимального элемента массива равна: {DiffMinMax(tempArray)}");
