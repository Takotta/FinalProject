Console.Write("Enter a size of array: ");
int size = int.Parse(Console.ReadLine());

string[] InitArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter {i + 1}/{size} element of array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] MakeArray(string[] array, int size) {
    string[] result = new string[size];
    int count = 0;
    foreach (var item in array) {
        if(item.Length <= 3) {
            // Add elements to the new array
            result[count] = item;
            count++;
        }
    }
    // Resize the new array
    Array.Resize(ref result, count);
    return result;
}

string[] array = InitArray(size);
string[] finalArray = MakeArray(array, size);
Console.WriteLine($"A new array of strings with length less than or equal to 3: [{String.Join(" ", finalArray)}]");
