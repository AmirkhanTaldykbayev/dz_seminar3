
int [] array = new int [10];
Random rand = new Random();

int numLen = array.Length;
int temp = rand.Next(100,1000);

for(int i = 0; i < numLen; i++)
{
      if ((temp / 100) + ((temp / 10) % 10) + (temp % 10) % 3 == 0)
      {
         array[i] = temp;
      }
}

Console.WriteLine(temp);
// Console.WriteLine(array);

// Console.WriteLine(temp);
// Console.WriteLine(temp / 100);
// Console.WriteLine((temp / 10) % 10);
// Console.WriteLine(temp % 10);

// string[] test = new string[3];
// Random rand = new Random();
// for(int i =0;i<test.Length;i++)
//    test[i] = Convert.ToString(rand.Next(-100,100));//Заполняем случайными числами диапозоном от -100 до 100

// string result = string.Join(",", test);
// Console.WriteLine(result);