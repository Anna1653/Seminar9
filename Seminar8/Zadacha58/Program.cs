/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

System.Console.Write("Введите количество строк первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов первой матрицы: ");
int colmns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов второй матрицы: ");
int colmns2 = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = InitMatrix(rows, colmns);
int[,] arr2 = InitMatrix(colmns, colmns2);
int[,] result = new int[rows, colmns2];

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        Multy(result, arr1, arr2, i, j);
    }
}

System.Console.WriteLine("Первая матрица:");
Print(arr1);
System.Console.WriteLine("Вторая матрица:");
Print(arr2);
System.Console.WriteLine("Произведение матриц:");
Print(result);

int[,] InitMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < colmns; l++)
        {
            tmp[i, l] = random.Next(1, 10);
        }  
    }
    return  tmp;
}

void Multy(int[,] result, int[,] arr1, int[,] arr2, int row, int column)
{
    int sum = 0;
    for (int j = 0; j < arr2.GetLength(0); j++)
    {
        sum = sum + arr1[row, j] * arr2[j, column];
    }
    result[row, column] = sum;
}

void Print(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
          System.Console.Write($"{ arr[i, l] }  ");
        }
        System.Console.WriteLine();
    } 
}