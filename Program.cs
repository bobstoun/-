// Задача 45. Найдите програму которая будет создавать копию заданного массива с помощю 
// поэлиментрного копирования.
Console.Clear();
 int[] g = {1,2,3,4,5};
 int[] list = g;
 int[] array = new int[list.Length];
  
for(int i=0;i<array.Length;i++)

array[i]=list[i];

list[0] = -5;

Console.WriteLine($"{string.Join(", ", list)}");
Console.WriteLine($"{string.Join(", ", array)}");






