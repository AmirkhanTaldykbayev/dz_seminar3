int[] array = new int[10];
Random random = new Random();
int rnd = Convert.ToInt32(random.Next(100,1000));

Console.WriteLine("Десятью случайно сгенерированными и интересными числами являются: ");
for (int i = 0; i < 10; i++)
    if (((rnd / 100) + ((rnd / 10) % 10) + (rnd % 10)) % 3 == 0)
    {
        array[i] = rnd;
        rnd = Convert.ToInt32(random.Next(100,1000));
        Console.Write($"{array[i]} \t");
    }
    else
    {
        i--;
        rnd = Convert.ToInt32(random.Next(100,1000));
    }


