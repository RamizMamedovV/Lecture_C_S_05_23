// Написать программу, которая отсортирует массив
// например от мин. значения до макс.(вариант 2й: от мак. до мин)

//                      неизменная часть для 2х вариантов

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}
//                              вариант 1

void SortArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length - 1; i++)
    {
       int minIndex = i;
        for (int j = i + 1; j < arr1.Length; j++)
        {
            if (arr1[j] < arr1[minIndex])
            {
                minIndex = j;
                int temp = arr1[minIndex];
                arr1[minIndex] = arr1[i];
                arr1[i] = temp;
            }
        }
        Console.WriteLine();
        PrintArray(arr1);
    }
}

//                              вариант 2

// void SortArray(int[] arr1)
// {
//     for (int i = 0; i < arr1.Length - 1; i++)
//     {
//         int maxIndex = i;
//         for (int j = i + 1; j < arr1.Length; j++)
//         {
//             if (arr1[j] > arr1[maxIndex])
//             {
//                 maxIndex = j;
//             }
//         }
//         int temp = arr1[maxIndex];
//         arr1[maxIndex] = arr1[i];
//         arr1[i] = temp;
//         Console.WriteLine();
//         PrintArray(arr1);
//     }
// }


int[] array = { 2, 6, 5, 8, 8, 4, 1, 1, 0, 0, 4 };
PrintArray(array);

SortArray(array);