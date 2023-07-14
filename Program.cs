string[] arrayIn1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] arrayIn2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arrayIn3 = new string[3] {"Russia", "Denmark", "Kazan"};

string[] arrayOut1 = new string[arrayIn1.Length];
string[] arrayOut2 = new string[arrayIn2.Length];
string[] arrayOut3 = new string[arrayIn3.Length];

void SecondArrayWithIF(string[] array1, string[] array2)
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
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(arrayIn1, arrayOut1);
PrintArray(arrayOut1);

SecondArrayWithIF(arrayIn2, arrayOut2);
PrintArray(arrayOut2);

SecondArrayWithIF(arrayIn3, arrayOut3);
PrintArray(arrayOut3);