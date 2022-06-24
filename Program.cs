Console.WriteLine(IsTheSame(1, 1));

static bool IsTheSame(int num1, int num2)
{
   if (num1 == num2)
    {
        return true;
    }

    return false;
}

Console.WriteLine(Subtract(2, 1));

static double Subtract(double num1, double num2)
{
    return num1 - num2;
}

MyBuildingType(1);

static void MyBuildingType(int num)
{
    if (num >= 4 && num <= 10)
    {
        Console.WriteLine("This is an office building!");
    }
    if (num >= 50)
    {
        Console.WriteLine("This is a SUPER skyscraper!");
    }
    if (num >= 11 && num <= 49)
    {
        Console.WriteLine("This is a skyscraper");
    }
    if (num < 3)
    {
        Console.WriteLine("This is a house!");
    }
    
}


