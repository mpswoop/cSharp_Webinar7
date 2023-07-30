// // See https://aka.ms/new-console-template for more information
Console.WriteLine("input amount of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input amount of columns");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

double[,] table = new double[rows, columns];

double[,] Fill()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            table[i, j] = new Random().Next(-9, 10)+ new Random().NextDouble();
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
            Console.Write(table[i, j]+ "    ");
        }
        Console.WriteLine();
    }
}

Fill();
Print();

// double num = new Random().NextDouble();
// Console.WriteLine(num);
// string cut = Convert.ToString(num);
// for (int i = 0; i < 3; i++)
// {
    
// }