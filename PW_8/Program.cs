using System;
namespace PW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int[,] Array = new int[10, 10];
                Random random = new Random();

                
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Array[i, j] = random.Next(1, 10);
                    }
                }

                
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write(Array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

               
                int GetLenght = Array.GetLength(0) - 2;
                int one = 1;
                int NewArray = Array[0, Array.GetLength(0) - 1];
                while (GetLenght >= 0)
                {
                    if (NewArray < Array[one, GetLenght])
                    {
                        NewArray = Array[one, GetLenght];
                    }
                    GetLenght--;
                    one++;
                }
                Console.WriteLine("Максимальный элемент побочной диагонали: " + NewArray);
                NewArray = 0;

               
                for (int i = 0; i <= 9; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        if (NewArray < Array[i, j])
                        {
                            NewArray = Array[i, j];
                        }
                    }
                }
                Console.WriteLine("Максимальный элемент главной диагонали: " + NewArray);

                
                for (int i = 0; i < Array.GetLength(1); i++)
                {
                    NewArray = 0;
                    for (int j = 0; j < Array.GetLength(0); j++)
                    {
                        NewArray += Array[j, i];
                    }
                    Console.WriteLine($"Сумма {i + 1} столбца: " + NewArray);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
