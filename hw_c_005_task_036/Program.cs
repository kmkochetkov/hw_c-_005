// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Заполняем масив случайными числами
int[] ComplArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(-1000,1000);
        index++;
    }
    return col;
}

// Проверка позиции элемента на нечётность
int OddSum(int[] col)
{
    int count = col.Length;
    int position = 0;
    int sum=0;
        while (position < count)
    {
        if ((position+1)%2 !=0)      // Проверяю, является ли позиция элемента нечётной
        {
            sum=sum+col[position]; // суммирование нечётных элементов
        }
        position++;
    }
    return sum;   
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
PrintArray(tempArray);
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {OddSum(tempArray)}");