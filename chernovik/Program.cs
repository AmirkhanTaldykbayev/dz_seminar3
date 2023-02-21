int[] array = new int[10];
Random random = new Random();
//int rnd = 0;
int i = 0;
int temp = Convert.ToInt32(random.Next(100, 1000)); 
int length = array.Length;

int InterestingNumber (int temp)
{
    int result = 0;
    temp = Convert.ToInt32(random.Next(100,1000));
    if (((temp / 100) + ((temp / 10) % 10) + (temp % 10)) % 3 == 0)
    {
        result = temp;
    }
    else
    {
        result = 0;
    }
    return result;
}

while(i < array.Length)
{
    if (temp != 0)
    {
    Console.Write($"{InterestingNumber(temp)} \t");
    i++;
    }
}
//array [i] != result

// Console.WriteLine("Десятью случайно сгенерированными и интересными числами являются: ");
// while (i < length)
// {

//     Console.WriteLine($"{temp} ");
// }


// if (((temp / 100) + ((temp / 10) % 10) + (temp % 10)) % 3 == 0)
// {
//     rnd = temp;
//     temp = Convert.ToInt32(random.Next(100, 1000));
// }
// else
// {
//     temp = Convert.ToInt32(random.Next(100, 1000));
// }
// Console.WriteLine(rnd);

// Console.WriteLine("Десятью случайно сгенерированными и интересными числами являются: ");
// for (int i = 0; i < 10; i++)
//     if (((rnd / 100) + ((rnd / 10) % 10) + (rnd % 10)) % 3 == 0)
//     {
//         array[i] = rnd;
//         rnd = Convert.ToInt32(random.Next(100,1000));
//         Console.Write($"{array[i]} \t");
//     }
//     else
//     {
//         i--;
//         rnd = Convert.ToInt32(random.Next(100,1000));
//     }


