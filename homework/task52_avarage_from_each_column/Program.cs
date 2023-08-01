// create table
// find avarage from colums

int[,] tabel = new int[4, 2];

void FillTabel()
{
    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1); j++)
        {
            tabel[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintTabel()
{
    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1); j++)
        {
            Console.Write(tabel[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[] sum = new double[tabel.GetLength(0)];


void FindSum()
{

    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1); j++)
        {
            sum[i] += tabel[i, j];
            // Console.WriteLine($"_________{i} {j}");
            // Console.Write(sum[i] + " ");
        }
        Console.WriteLine();
    }

}

double[] average = new double[tabel.GetLength(1)];

void FindAverage()
{

    for (int i = 0; i < tabel.GetLength(1); i++)
    {

        average[i] = sum[i] / (tabel.GetLength(0));
    }

}

void PrintSum()
{
    Console.WriteLine();

    for (int i = 0; i < sum.GetLength(0); i++)
    {
        Console.Write(sum[i] + " ");
    }
    Console.WriteLine();
}


void PrintAverage()
{
    Console.WriteLine();

    for (int i = 0; i < average.GetLength(0); i++)
    {
        Console.Write(average[i] + " ");
    }
    Console.WriteLine();
}

FillTabel();
PrintTabel();
Console.WriteLine("");
FindSum();
FindAverage();
PrintSum();
PrintAverage();

