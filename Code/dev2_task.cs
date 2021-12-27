class Program
{
    static void Main(string[] args)
    {
        int[] MyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] NewArray = { };
        for (int i = 0; i < MyArray.Length; i++)
        {
            if (MyArray[i] % 2 == 0)
            {
                NewArray[i] = MyArray[i];
            }

        }

        Console.WriteLine(NewArray);
    }
}



