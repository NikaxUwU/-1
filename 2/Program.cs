int num = Convert.ToInt32(Console.ReadLine());

int test = num / 100;

if (test > 0)
{
    while (num > 999)
    {
        num = num / 10;
    }

    int res = num % 10;
    Console.Write(res);
}

else
{
    Console.Write("Нет третьего числа");
}