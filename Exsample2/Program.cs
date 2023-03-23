
void Print (int [,] matrix)
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
int [,] Matrix (int rows, int columns, int left, int right)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = Random.Shared.Next(left, right+1);
       }
    }   
    return matrix;
}

void Solution (int [,] matrix)
{
Console.Write ($" Введите индекс в строке ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write ($" Введите индекс в столбце ");
int b = Convert.ToInt32 (Console.ReadLine ());
int [,] Array = matrix;
for (int i = 0; i < Array.GetLength (0); i++) 
{
    for (int j = 0; j < Array.GetLength (1); j++)
    {
        if (i == a && j == b)
        {
            Console.WriteLine ($" {Array [i, j]} ");
            return;
        }
    }
}
Console.WriteLine ($" Tакого числа нет в данном массиве. ");
}


const int ROWS = 5;
const int COLUMNS = 5;
const int LEFTBORDER = 1;
const int RIGHTBORDER = 10;
int [,] newMatrix = Matrix (ROWS, COLUMNS, LEFTBORDER, RIGHTBORDER);
Print (newMatrix);

Solution (newMatrix);
