﻿Console.Write ("Введите число элементов массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
int [] numbers = new int [a];
FillArray (numbers);
PrintArray (numbers);
int sum = 0;
for (int i = 0; i < a; i++)
    {
        if (i % 2 != 0)
         {
             sum = sum + numbers[i];
         }
    }
    Console.WriteLine ("Cумма элементов, стоящих на нечётных позициях: "+sum);

void FillArray (int [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
       numbers [i] = new Random().Next(0,100);
    }

  }

  void PrintArray (int [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
       Console.Write (numbers [i] + " ");
    }
    Console.WriteLine();
  }