//Console.Clear();
//Console.Write("hello, world");
//int i = 45;
//Console.WriteLine(i);

//Console.Clear();
//Console.WriteLine("name plis");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.ReadLine();
//Console.WriteLine($"{a * a }");

//Console.Clear();
//Console.WriteLine("Ведите веше имя");
//Console.ReadLine();ЭКСПЕРИМЕНТ
//Console.Clear();
//Console.WriteLine($" {Console.ReadLine()}  Добропожаловать");

//Console.Clear();
//Console.WriteLine("ВЕДИТЕ ЧИСЛО");
//int year = Convert.ToInt32(Console.ReadLine());  
//   if (year%400==0||year%100!=0&&year%3==0)
//    Console.WriteLine("yes");
//   Console.WriteLine("no");

//Console.Clear();
//Console.WriteLine("Ведите цифры");
//int g = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{g*g}");


// Console.Clear();
//Console.Write("Ведите число  ");
//int f = Convert.ToInt32(Console.ReadLine());   
//while (f < 1 || f > 7)
//{
//Console.Write("Ошибка, ведите день недели напремер,от 1 до 7: ");
//f = Convert.ToInt32(Console.ReadLine());
//}
//Console.Clear(); 
//if (f == 1)
//Console.WriteLine("понедельк");

//else if (f == 2)
//Console.WriteLine("вторник");

//else if (f == 3)
//Console.WriteLine("среда");

//else if (f == 4)
//Console.WriteLine("четверг");

//else if (f == 5)
//Console.WriteLine("пятница");

//else if (f == 6)
//Console.WriteLine("суббота");

//if (f == 7)
//Console.WriteLine("воскресенье");


//Console.Clear();
//Console.Write("ведите день недели ВЫХОДНОЙ ");
//int king = Convert.ToInt32(Console.ReadLine());
//while (king < 6 || king > 7 )
//{
//Console.Write($"ошибка вы ввели {king} ведите другую цифру к примеру 6 или 7. ");
//king = Convert.ToInt32(Console.ReadLine());
//}
//Console.Clear();
//if (king == 6)
//Console.WriteLine("Правильно Суббота");
//if (king == 7)
//Console.WriteLine("Правильно Воскресенье");


//Console.Clear();
//Console.Write("ведите число ");
//int r = Convert.ToInt32(Console.ReadLine());
//while (r < 1 || r > 3 )
//{
//Console.Write($"ошибка вы вели {r} ведите правильно к примеру 1 или 2 или 3. ");
//r = Convert.ToInt32(Console.ReadLine());
//}
//Console.Clear();
//if (r == 1)
//Console.WriteLine("правильно, g");
//if (r == 2)
//Console.WriteLine("правильно, c");
//if (r == 3)
//Console.WriteLine("правильно, v");


//Console.Clear();
//Console.Write("ведите кол-во элементов масива ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n];
//for (int i=0 ; i < array.Length; i++)
//{
//Console.Write($"ОШИБКА ведите элимент масива {i + 1} ");
//array [i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine($"[{string.Join(", ",  array)}]");


//Console.Clear();
//Console.Write("ВЕДИТЕ ЛЮБЫЕ ЧИСЛА МАССИВА,обозначаюшие размер массива: ");
//int r = Convert.ToInt32(Console.ReadLine());
//int[] zoro = new int[r];
//for (int i = 0; i < zoro.Length; i++)
//{
//Console.Write($"ведите{i + 1} элимент массива ");
//zoro [i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine($"[{string.Join(",    ",zoro)}]");


//Console.Clear();
//Console.Write("напишите все  3 цифры  ");
//int b = Convert.ToInt32(Console.ReadLine());
//if ( b < 1 || b > 3)
//{
//Console.Write("ОШИБКА напишите одну из этих 1 2 3 цифр: ");
//b = Convert.ToInt32(Console.ReadLine());
//} 
//if (b == 1)
//Console.WriteLine("x");
//if (b == 2)
//Console.WriteLine("n");
//if (b == 3)
//Console.WriteLine("y");

//находим корень
//Console.Write("ВКООРДИНАТ X2 ");
//double x_1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("ВКООРДИНАТ X2 ");
//double x_2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("ВКООРДИНАТ Y 1 ");
//double y_1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("ВКООРДИНАТ Y2 ");
//double y_2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x_1 - x_2, 2) + Math.Pow(y_1 - y_2, 2)), 2));


//пятизначное чиссло являтсяли палиндром 
//Console.Clear();
//Console.Write("ВЕДИТЕ ЧИСЛО ");
//string? number = Console.ReadLine();
//int count = number.Length - 1;
//double NewNumber = 0;
//for(int i = count;i >= 0;i--)
//{
  //  NewNumber = NewNumber + int.Parse(number [i].ToString()) * Math.Pow(10,i);
//}
//Console.WriteLine(number==NewNumber.ToString());

Console.Clear();
Console.Write("ведите число массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
for (int i = 0; i < Array.Length;i++)
{
  Console.Write($"пишите число {i + 1} ");
  Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", Array)}]");