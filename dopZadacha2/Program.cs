/*
Доп. задание №2:
Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по величине цифре. 
Напишите программу, которая определяет интересное число или нет. Если число интересное, следует вывести – «Число интересное», 
иначе «Число неинтересное».
-> 954 - число интересное, средняя цифра - 5, разница: 9 - 5 = 4.
Средняя цифра - цифра(962-6, 23456 - средняя 4)
*/


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int indexMin = 0;
int indexMax = 0;
int indexMid = number.Length / 2;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > number[indexMax])
    {
        indexMax = i;
    }
    else if (number[i] < number[indexMin])
    {
        indexMin = i;
    }
}

char a = number[indexMax];
int max = int.Parse(a.ToString());
char b = number[indexMin];
int min = int.Parse(b.ToString());
char c = number[indexMid];
int mid = int.Parse(c.ToString());

if (max - mid == min)
{
    Console.WriteLine("Число интересное");
}
else
{
    Console.WriteLine("Число неинтересное");
}



/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int[] b = new int[str.Length];

for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}


Console.WriteLine(b[1]);
*/