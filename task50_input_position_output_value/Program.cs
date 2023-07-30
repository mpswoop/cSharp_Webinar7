// // See https://aka.ms/new-console-template for more information
Console.WriteLine("check value of a table cell");
Console.WriteLine();
Console.WriteLine("input row number");
int rowsNo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input column number");
int columnsNo = Convert.ToInt32(Console.ReadLine());

int rows = 8;
int columns = 8;


Console.WriteLine("");

double[,] table = new double[rows, columns];

double[,] Fill()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            table[i, j] = new Random().Next(1, 10);
            //Console.WriteLine(table[i, j]);
        }

    }
    return table;
}

void Print()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(table[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void Check()
{
    if( rowsNo>rows || columnsNo>columns )
    {
        Console.WriteLine("Coordinates outside table size");
    }
    else
    {
        Console.WriteLine("Cell Value:");
        Console.WriteLine(table[rowsNo-1,columnsNo-1]);
    }
}

Fill();
Print();
Check();
