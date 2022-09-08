// необходимо отсортировать все элементы 
// массива от наименьшеного к наибольшему (1,5,6,2,4,3,8,7,4,2,3,5)

int[] arr = {1,5,6,2,4,3,8,7,4,2,3,5};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    Console.Write( $"{array[i]}");
}
Console.WriteLine ();

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minposition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minposition]) minposition = j;

        }
    int temporary = array[i];
    array[i] = array[minposition];
    array[minposition] = temporary;
    }
}
PrintArray (arr);
Console.WriteLine ();
SelectionSort(arr);

PrintArray (arr);


