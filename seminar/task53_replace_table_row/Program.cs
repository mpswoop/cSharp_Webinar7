// create table
// replace first row by last row

int[,] table = new int[8, 8];

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

void ReplaceRow()
{

    for (int i = 0; i < table.GetLength(1); i++)
    {
        int[] array = new int[table.GetLength(1)];
        array[i] = table[(table.GetLength(0) - 1), i];
        table[(table.GetLength(0) - 1), i] = table[0, i];
        table[0, i] = array[i];
    }


}

FillTable();
PrintTable();
ReplaceRow();
Console.WriteLine("");
PrintTable();

