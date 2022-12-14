Console.Clear();
Console.Write("Введите трехзначное число, чтобы увидеть его вторую цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100)
    Console.Write($"{(n / 10) % 10}");
else
    while (n < 100) {
        Console.Write("Число не трехзначное!\nВведите трехзначное число, чтобы увидеть его вторую цифру: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write($"{(n / 10) % 10}");