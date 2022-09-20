// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




// Заполняем масив случайными числами.
int[] ComplArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(0,10);
        index++;
    }
    return col;
}

// Расчёт элементов нового массива
int[] MultDoubleArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    int[] mult = new int[count/2];
    
    while (position < count/2)
        {
            mult[position] = (col[position]*col[(count-1)-position]);
            position++;
        }
    return mult;   
}

////////////////////////////////////////
//Для наглядности работы и проверки работы введёна распечатка массива.

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
Console.WriteLine("Исходный массив:");
PrintArray(tempArray);
int[] multArray = MultDoubleArray(tempArray);
Console.WriteLine("Массив произведений членов исходного массива, равноудалённные по индексу от центра: ");
PrintArray(multArray);





