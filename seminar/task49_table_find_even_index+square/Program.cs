
int[,] table = new int[4,4];

void FillTable()
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintTable()
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SquareEven()
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if ((i+1) % 2 == 0 && (j+1) % 2 == 0)
            {
                table[i,j] *= table[i,j];
            }
        }
        Console.WriteLine();
    }
}

FillTable();
PrintTable();
SquareEven();
PrintTable();