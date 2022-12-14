Console.Clear();
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 * n1 == n2 || n2 * n2 == n1)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");