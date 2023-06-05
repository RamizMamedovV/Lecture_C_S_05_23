
// int[,] array = new int[2, 3];
// ArrFillInt(array);

// void ArrFillInt(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($" {i}{j} -");
//             //  Console.WriteLine("-");
//         }
//         Console.WriteLine();
//     }
// }

string[,] strings = new string[2, 3];
ArrFillInt(strings);

void ArrFillInt(string[,] str)
{
    string str1 = String.Empty;
    for (int i = 0; i < str.GetLength(0); i++)
    {
            str1 = " //Ab-";
        for (int j = 0; j < str.GetLength(1); j++)
        {
            int a = 1;
            str1 += str1;
            Console.Write(a + str1);
        }
        Console.WriteLine();
    }
}