void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
string[] array1 = new string[7] {"hello", "cat", "USA", "Windows", "123", "2", "Dog"};
string[] array2 = new string[array1.Length];

SecondArray(array1, array2);
WriteArray(array2);