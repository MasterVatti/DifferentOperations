using System;

namespace TT_hoby.MatrixOperations
{
  public class MatrixOperations
  {
    public void CountMatrixSum()
    {
      int[,] matrix = InputMatrix();
      DisplayMatrix(matrix);
      CalculateMatrixSum(matrix);
    }

    public void CountMatrixMultipleSum()
    {
      int[,] matrix = InputMatrix();
      DisplayMatrix(matrix);
      CalculateMutlipleSum(matrix);
    }

    private int[,] InputMatrix()
    {
      Console.WriteLine("Input matrix size");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input elements");
      
      int[,] matrix = new int[n, n];
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++) matrix[i, j] = Convert.ToInt32(Console.ReadLine());
      }

      return matrix;
    }

    private void DisplayMatrix(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++) Console.Write(matrix[i, j]);

        Console.WriteLine();
      }
    }

    private void CalculateMatrixSum(int[,] matrix)
    {
      int sum = 0;
      for (int i = 0; i < matrix.GetLength(0); i++) sum += matrix[i, i];

      Console.WriteLine("Sum = " + sum);
    }

    private void CalculateMutlipleSum(int[,] matrix)
    {
      Console.WriteLine("Input multiple");

      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
          if (matrix[i, j] % n == 0) sum += matrix[i, j];
      }

      Console.WriteLine($"Multiple {n} sum = " + sum);
    }
  }
}