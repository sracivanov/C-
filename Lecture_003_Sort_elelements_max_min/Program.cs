// необходимо отсортировать все элементы 
// массива от наибольшего к наименьшему (1,5,6,2,4,3,8,7,4,2,3,5)
int [] arr = {1,5,6,2,4,3,8,7,4,2,3,5};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    Console.Write ($"{array[i]}");
}

void SortedMax (int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
        {
        int Max = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array [Max]) Max =j; 
        }

    int temporary = array[i]; // переменной в массиве присваиваем значение элемента (i) этого массива 
    array[i] = array [Max]; // элементу массива присваиваем значение наибольшего элемента массива 
    array[Max] = temporary; // наибольшему элементу массива присваиваем значение переменной в этом массиве
    }
}
PrintArray (arr);
Console.WriteLine ();
SortedMax(arr);

PrintArray (arr);

