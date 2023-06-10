// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



Console.WriteLine("Введите ширину двухмерного массива ");
int Nomer1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину двухмерного массива ");
int Nomer2 =Convert.ToInt32(Console.ReadLine());

int [,] array2d = new int [Nomer1,Nomer2];
for (int i =0; i<array2d.GetLength(0); i++)     //Генерация массива
{
    for (int j =0; j<array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(1,10);
        Console.Write(array2d[i,j] + "  ");
    }
Console.WriteLine();
}

Console.WriteLine("Сортировка:");

for (int i = 0 ; i<array2d.GetLength(0); i++)   //Сортировка
{
    for (int j = 0 ; j<array2d.GetLength(1); j++)
{
        for (int k = 0 ; k<array2d.GetLength(1)-1; k++)
{
            if (array2d[i,k] <array2d[i,k+1])
            {
            int temp = array2d[i,k+1];
            array2d[i,k+1] = array2d[i,k];
            array2d[i,k] = temp;
            }
}
}
}

for (int i = 0 ; i<array2d.GetLength(0); i++)   //Вывод
{
    for (int j = 0 ; j<array2d.GetLength(1); j++)
{
    Console.Write(array2d[i,j] + "  ");
}
Console.WriteLine();
}

//---------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите высоту двухмерного массива ");
int Nomer1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите длину двухмерного массива ");
int Nomer2 = 4;//Convert.ToInt32(Console.ReadLine());

int [,] array2d = new int [Nomer1,Nomer2];
for (int i =0; i<array2d.GetLength(0); i++)     //Генерация массива
{
    for (int j =0; j<array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(1,10);
        Console.Write(array2d[i,j] + "  ");
    }
Console.WriteLine();
}


int min= 0;
int minsumma = 0;
int sumRow = 0;
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        min += array2d[0, i];
    }
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++) sumRow += array2d[i, j];
        if (sumRow < min)
        {
            min = sumRow;
            minsumma = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minsumma + 1} строка");

//----------------------------------------
    
    // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите высоту первого двухмерного массива ");
int Nomer1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину первого двухмерного массива ");
int Nomer2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту второго двухмерного массива ");
int Nomer3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второго двухмерного массива ");
int Nomer4 = Convert.ToInt32(Console.ReadLine());

int [,] array2d = new int [Nomer1,Nomer2];
for (int i =0; i<array2d.GetLength(0); i++)     //Генерация массива
{
    for (int j =0; j<array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(1,10);
        Console.Write(array2d[i,j] + "  ");
    }
Console.WriteLine();
}
Console.WriteLine();

int [,] array3d = new int [Nomer3,Nomer4];
for (int i =0; i<array3d.GetLength(0); i++)     //Генерация 2 массива
{
    for (int j =0; j<array3d.GetLength(1); j++)
    {
        array3d[i,j] = new Random().Next(1,10);
        Console.Write(array3d[i,j] + "  ");
    }
Console.WriteLine();
}
int [,] array_result= new int[Nomer1,Nomer2];                // Конечный массив

for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array3d.GetLength(1); j++)
                {
                    for (int k = 0; k < array3d.GetLength(0); k++)
                    {
                        array_result[i,j] += array2d[i,k] * array3d[k,j];
                    }
                }
            }

Console.WriteLine("Результат:");
for (int i =0; i<array_result.GetLength(0); i++)     
{
    for (int j =0; j<array_result.GetLength(1); j++)
    {
        
        Console.Write(array_result[i,j] + "  ");
    }
    Console.WriteLine();
}


//--------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите высоту первого двухмерного массива ");
int Nomer1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину первого двухмерного массива ");
int Nomer2 = Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int [Nomer1,Nomer2];


int temp = 1;
int i = 0;
int j = 0;

while (temp <= array2d.GetLength(0) * array2d.GetLength(1))
{
  array2d[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array2d.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array2d.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array2d.GetLength(1) - 1)
    j--;
  else
    i--;
}

for (int e =0; e<array2d.GetLength(0); e++)    
{
    for (int l =0; l<array2d.GetLength(1); l++)
    {
        Console.Write(array2d[e,l] + "  ");
    }
Console.WriteLine();
}