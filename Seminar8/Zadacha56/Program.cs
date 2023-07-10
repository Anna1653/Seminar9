/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

System.Console.Write("Введите количество строк :");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов, которые будут равны количеству строк :");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows,colmns);

Print(matrix);

GetMinSumRow(matrix);

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

void GetMinSumRow(int[,] arr)
{
    int num = 0;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (i == 0 || sum < minSum) {
            minSum = sum;
            num = i;
        }
    }
    System.Console.Write($"Номер строки с наименьшей суммой элементов: {num + 1}, сумма строки равна: {minSum}");
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