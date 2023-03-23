//Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Matrix (int rows, int columns, int leftBorder, int rightBorder)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder+1);
       }
    }   
    return matrix;
}

void print (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write (matrix[i, j] + " ");
        }
    Console.WriteLine();
    }
}



void Result (int [,] matrix)
{
    int [,] matrix1 = matrix;
    for (int j = 0; j < matrix1.GetLength (0); j++) 
    {
        double sum = 0;
        for (int i = 0; i < matrix1.GetLength (0); i++) 
        {
        sum += matrix1[i, j];
        }
    sum /= matrix1.GetLength (1);
    Console.Write($" {sum}, ");
     }
}

const int ROWS = 5;
const int COLUMNS = 5;
const int LEFTBORDER = 0;
const int RIGHTBORDER = 10;
int [,] myMatrix = Matrix (ROWS, COLUMNS, LEFTBORDER, RIGHTBORDER);
print (myMatrix);
Result(myMatrix);