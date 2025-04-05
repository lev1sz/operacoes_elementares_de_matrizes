using System;
class MyMatrix
{
    private int rows, cols;
    private int[,] matrix;
    public MyMatrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new int[rows, cols];
    }
    public void InsertNumbers()
    {
        for (int i = 0;i < this.rows; i++)
        {
            for (int j = 0;j < this.cols; j++)
            {
                Console.Write($"Insira um numero na celula {i+1}{j+1}: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    public void PrintMatrix()
    {
        
        for (int i = 0;i < this.rows; i++)
        {
            Console.Write("[");
            for (int j = 0;j < this.cols; j++)
            {
                Console.Write($" {matrix[i, j]} ");
            }
            Console.WriteLine("]");
        }
    }
    public void Permute(int i, int j)
    {
        int[] aux = new int[cols];
        i--;
        j--;
        for(int k = 0; k < cols; k++)
        {
            aux[k] = matrix[i, k];
        }
        for(int k = 0; k < cols; k++)
        {
            matrix[i, k] = matrix[j, k];
        }
        for(int k = 0; k < cols; k++)
        {
            matrix[j, k] = aux[k];
        }

    }
    public void Multiply(int i, int alpha)
    {
        i--;
        for(int j = 0; j < cols; j++)
        {
            matrix[i, j] *= alpha;
        }
    }
    public void MultiplyAndSum(int i, int j, int alpha)
    {
        i--;
        j--;
        for(int k = 0; k < cols; k++)
        {
            matrix[i, k] += matrix[j, k] * alpha;
        }
    }
} 