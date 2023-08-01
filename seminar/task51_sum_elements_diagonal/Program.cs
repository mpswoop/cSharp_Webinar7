// return sum of numbers on main diagonal

int[,] table = new int[4, 4];

void FillTable()
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintTable()
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SquareEven()
{
    int sum = table[0, 0];
    for (int i = 1; i < table.GetLength(0); i++)
    {
        for (int j = 1; j < table.GetLength(1); j++)
        {
            if (i + 1 == j + 1)
            {
                sum += table[i, j];
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine(sum);

}

FillTable();
PrintTable();
SquareEven();
