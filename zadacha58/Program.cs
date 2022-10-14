// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// В условии не указано, буду брать квадратные.

Console.WriteLine("Даны две матрицы размерами n x n элементов.");
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = new int[n, n];
int[,] secondMartrix = new int[n, n];

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArrayRandom(firstMartrix);
Console.WriteLine($"Первая матрица: ");
PrintArray(firstMartrix);

FillArrayRandom(secondMartrix);
Console.WriteLine($"Вторая матрица: ");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[n, n];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);