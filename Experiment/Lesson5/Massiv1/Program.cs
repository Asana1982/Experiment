// string [,] table = new string [2, 5];
// // table [0, 0] table [0, 1]
// // table [0, 1] table [1, 1]
// table[1, 2]= "word";
// for (int rows = 0; rows < 2; rows++)
//     {
//         for (int columns  = 0; columns < 5; columns++)
//         {
//             Console.WriteLine($"-{table[rows, columns]}-");
//         }
//     }


void PrintImage (int[,] image)
{

    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            
            if(image[i, j] == 0) Console.Write($" ");
            else Console.WriteLine($"+");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int [,] matrix = new int [3, 4];
PrintImage(matrix);
FillArray(matrix);
Console.WriteLine();
PrintImage(matrix);