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


    Console.Clear();
   Console.Write("Ведите число  ");
   int f = Convert.ToInt32(Console.ReadLine());   
   while (f < 1 || f > 7)
   {
    Console.Write("Ошибка, ведите день недели напремер,от 1 до 7: ");
    f = Convert.ToInt32(Console.ReadLine());
   }
    Console.Clear(); 
  if (f == 1)
   Console.WriteLine("понедельк");
    
  else if (f == 2)
   Console.WriteLine("вторник");

  else if (f == 3)
   Console.WriteLine("среда");

  else if (f == 4)
   Console.WriteLine("четверг");

  else if (f == 5)
   Console.WriteLine("пятница");

  else if (f == 6)
   Console.WriteLine("суббота");

  if (f == 7)
   Console.WriteLine("воскресенье");