// Написать программу, которая отсортирует массив
// например от мин. значения до макс.

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}

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

int[] array = { 2, 6, 8, 8, 4, 1, 1, 0, 0, 4 };
PrintArray(array);

SortArray(array);