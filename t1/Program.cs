// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.WriteLine("введите количество чисел:");
int size = int.Parse(Console.ReadLine());
int [] array = new int [size];

VvodChisel(array);
PrintArray(array);
Console.WriteLine($"Чисел больше 0 - {PositiveNumbers(array)}");

void VvodChisel(int[] arra)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число: ");
        arra[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        Console.Write(",");
        position++;
    }
   
}

int PositiveNumbers(int[] arra)
{
int positiveSum = 0;
   for (int i = 0; i < arra.Length; i++)
   {
    if(arra[i] > 0)
        positiveSum += 1;
   }
   return positiveSum;
}

