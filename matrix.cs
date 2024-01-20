using System;

class ProgramMatrix
{
    static int[,] GenMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        int top = 0, bottom = n - 1, left = 0, right = n - 1;
        int currentValue = 1;

        while (currentValue <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = currentValue++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = currentValue++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = currentValue++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = currentValue++;
            }
            left++;
        }

        return matrix;
    }

    static void ShowMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void main()
    {
        
        Console.WriteLine(" Calling Function with argument value 2  matrix(2):");
        ShowMatrix(GenMatrix(2));

        Console.WriteLine("\n Calling Function with argument value 3  matrix(3):");
        ShowMatrix(GenMatrix(3));

        Console.WriteLine("\n Calling Function with argument value 4  matrix(4):");
        ShowMatrix(GenMatrix(4));
    }
}
