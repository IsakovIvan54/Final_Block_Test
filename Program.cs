string[] arrayIn1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] arrayIn2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arrayIn3 = new string[3] {"Russia", "Denmark", "Kazan"};

string[] arrayOut1 = new string[arrayIn1.Length];
string[] arrayOut2 = new string[arrayIn2.Length];
string[] arrayOut3 = new string[arrayIn3.Length];

void SecondArray(string[] arrayIn, string[] arrayOut)
{
    int count = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
    if(arrayIn[i].Length <= 3)
        {
        arrayOut[count] = arrayIn[i];
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

SecondArray(arrayIn1, arrayOut1);
PrintArray(arrayOut1);

SecondArray(arrayIn2, arrayOut2);
PrintArray(arrayOut2);

SecondArray(arrayIn3, arrayOut3);
PrintArray(arrayOut3);