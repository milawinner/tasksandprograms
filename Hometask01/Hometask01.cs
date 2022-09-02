Console.Clear();
int num = new Random (). Next (100, 1000);
Console.WriteLine(num);
int numB = num / 100;
Console.Write(numB); // первое число
int numA = num % 10;// последнее число
Console.Write(numA);