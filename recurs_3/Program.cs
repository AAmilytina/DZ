// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void RArray(int[] array, int first, int last)
{
    if(first<last)
    {
        int temp = array[first];
        array[first] = array[last];
        array[last] = temp;
        RArray(array, first + 1, last - 1);
    }
}

Console.Clear();
int[] arr = {10, 8, 4, 33, 7, 34, 5};
RArray(arr, 0, arr.Length - 1);
string elements = String.Join(" ", arr);
Console.WriteLine(elements);