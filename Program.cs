
// task 58. Программа нахождения произведения двух матриц

int[,] Matrix1 = new int [,]{{2, 4}, 
                             {3, 2}};
int[,] Matrix2 = new int [,]{{3, 4},
                             {3, 3}};
int[,] ResultMatrix = new int [Matrix1.GetLength(0), Matrix1.GetLength(0)];

for (int i = 0; i < ResultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Matrix1.GetLength(1); k++)
      {
        sum += Matrix1[i,k] * Matrix2[k,j];
      }
      ResultMatrix[i,j] = sum;
    }
}

for (int i = 0; i < ResultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
    {
      Console.Write(ResultMatrix[i,j] + " ");
    }
    Console.WriteLine();
  }
