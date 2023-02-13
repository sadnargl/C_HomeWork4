int [] FillIntRandomArray (int size)
{
    int [] Array = new int [size];
   Random rnd = new Random ();
    for (int i = 0; i < size; i++)
    {
       Array [i] = rnd.Next ();
    }
    return Array;
}
void PrintArray (int [] Array)
{
    for (int i = 0; i < Array.Length-1; i++)
    {
       Console.WriteLine (Array[i]);
    }
}

int [] arr = FillIntRandomArray (8);
PrintArray (arr);