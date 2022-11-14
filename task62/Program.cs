void NewMatrix(int[,] matrix )
{
   int temp = 1, i = 0, j = 0;
   while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
   {
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) -1 )
         j++;
    
    else if (i < j  && i + j >= matrix.GetLength(0) -1 )
          i++;
   
    else if (i >= j && i + j > matrix.GetLength(1) -1 )
          j--;
    else
    i--;
   }
   for (i = 0; i < matrix.GetLength(0); i++)
   {
    for (j = 0; j < matrix.GetLength(1); j++)
       Console.Write(matrix[i, j] + "\t");
       Console.WriteLine();
   }
}
 

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] MatrixOne = new int[x, y];
NewMatrix(MatrixOne);
