using System;

void minFunct(ref int a, ref int b)//try to use pascal notation for the void names
{
    int temp = 0;
    temp = a;
    a = b;
    b = temp;

}

void BubbleSort(int[] arr)
{
    bool wasChanges = false;
    do
    {
        wasChanges = false;
        for (int i = 0; i < arr.Length - 1; i++)
        {

            if (arr[i] > arr[i + 1])
            {
                minFunct(ref arr[i], ref arr[i + 1]);
                wasChanges = true;
            }
        }
    } while (wasChanges);
}

int[] arr = { 9, 5, 2, 1, 4, 0, 8, 0, 3, 6, 7, 5, 8 };
BubbleSort(arr);
Console.WriteLine("BubbleSort");
for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

void SelectionSort(int[] arr)
{
    int minI = 0;

    for (int k = 0; k < arr.Length; k++)
    {
        int min = arr[k];
        for (int i = k; i < arr.Length; i++)
        {
            min = Math.Min(min, arr[i]);
            if (min == arr[i]) minI = i;
        }
        if (min != arr[k])
        {
            int temp = arr[k];
            arr[k] = min;
            arr[minI] = temp;
        }
    }
}
Console.WriteLine("");
Console.WriteLine("SelectionSort");
arr = new int[] { 9, 5, 2, 1, 4, 0, 8, 0, 3, 6, 7, 5, 8 };
SelectionSort(arr);
for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

void InsertionSort(int[] arr)
{
    bool wasChanges = false;

    for (int i = 0; i < arr.Length - 1; i++)
    {

        if (arr[i] > arr[i + 1])
        {
            minFunct(ref arr[i], ref arr[i + 1]);
            wasChanges = true;
        }

        if (i > 0 && wasChanges)
        {
            for (int k = i; k > 0; k--)
            {
                if (arr[k - 1] > arr[k])
                {
                    minFunct(ref arr[k - 1], ref arr[k]);
                    wasChanges = true;
                }
            }
        }
    }
}

Console.WriteLine("");
Console.WriteLine("SelectionSort");
arr = new int[] { 9, 5, 2, 1, 4, 0, 8, 0, 3, 6, 7, 5, 8 };
InsertionSort(arr);
for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
//it would be better to make the voids realization in area, below the main code
void Sort(int[] arr, SortAlgorithmType AlgorithmType, OrderBy OrderType)
{
    if (AlgorithmType == SortAlgorithmType.BubbleSort) BubbleSort(arr);
    else if (AlgorithmType == SortAlgorithmType.InsertionSort) InsertionSort(arr);
    else if (AlgorithmType == SortAlgorithmType.SelectionSort) SelectionSort(arr);

    if (OrderType == OrderBy.desc)
    {
        Console.WriteLine("");
        Console.WriteLine("SortAlgorithmType = " + AlgorithmType);
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i] + " ");

    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("SortAlgorithmType = " + AlgorithmType);
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
    }


}

arr = new int[] { 9, 5, 2, 1, 4, 0, 8, 0, 3, 6, 7, 5, 8 };
Sort(arr, SortAlgorithmType.InsertionSort, OrderBy.asc);
Sort(arr, SortAlgorithmType.BubbleSort, OrderBy.desc);

public enum SortAlgorithmType
{
    BubbleSort,
    SelectionSort,
    InsertionSort
}
public enum OrderBy
{
    asc,
    desc
}
//checked
