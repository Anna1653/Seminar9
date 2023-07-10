/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

System.Console.Write("Введите количество строк :");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов :");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows,colmns);
Print(matrix);

SortMatrix(matrix);
Print(matrix);


int[,] InitMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < colmns; l++)
        {
            tmp[i, l] = random.Next(1, 11);
        }  
    }
    return  tmp;
}

void SortMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        SortRow(arr, i);
    }
    Console.WriteLine($"Получился массив: ");
}

void SortRow(int[,] arr, int row)
{
    int temp;
    for (int l = 0; l < arr.GetLength(1); l++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1 - l; j++)
        {
            if (arr[row, j] < arr[row, j + 1]) 
            {
                temp = arr[row, j];
                arr[row, j] = arr[row, j + 1];
                arr[row, j + 1] = temp;
            }
        }
    }
}

void Print(int[,] arr){
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
          System.Console.Write($"{ arr[i, l] }  " );
        }
        System.Console.WriteLine();
    } 
}