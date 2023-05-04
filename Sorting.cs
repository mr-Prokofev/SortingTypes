public static class Sorting
 {public static int[] SelectionSort(this int[] arr)
{
    
    for (int i = 0; i < arr.Length-1; i++)
    {
        //int workNum = arr[i];
        int pos = i;
        for (int j = i+1; j < arr.Length; j++)
        {
             if (arr[j] < arr[pos]) pos = j;              
        }
        int Tmp = arr[i];
        arr[i] = arr[pos];
        arr[pos] = Tmp;
    }
    return arr;
}}