
int[,] table = new int[3,4];

void FillTable()
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = i+j;
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

FillTable();
PrintTable();