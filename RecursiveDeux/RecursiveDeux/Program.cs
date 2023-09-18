//Exercice A

int LinearSearch(int[] arr, int x)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
            return i;
    }
    return -1; // élément non trouvé
}static int LinearSearchRecursive(int[] arr, int x, int? index = 0)
{

    if (index >= arr.Length)
        return -1;

    if (arr[(int)index] == x)
        return (int)index;

    return LinearSearchRecursive(arr, x, index+1);
}

int[] table = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Le chiffre recherche se trouve à l'index:" + LinearSearchRecursive(table, 3));

//Exercice B 

int[] CumulativeSum(int[] arr)
{
    int[] result = new int[arr.Length];
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        result[i] = sum;
    }
    return result;
}

int[] CumulativeSumRec(int[] arr, int iteration = 0, int sum= 0)
{
    int[] result = new int[arr.Length];
    if (iteration >= arr.Length)
        return result;
    if(iteration == 0)
    {
        result[iteration] = arr[iteration];
        return result;
    }
    else
    {
        sum += arr[arr[iteration]];
        result[iteration] = sum;
        return CumulativeSumRec(arr);
    }
}

int[] result = CumulativeSum(table);

foreach(var elem in result)
    Console.WriteLine(elem);

//Exercice C

void BubbleSort(int[] arr)
{
    int n = arr.Length;
    bool swapped;
    do
    {
        swapped = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                // Échange
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }
    }
    while (swapped);
}