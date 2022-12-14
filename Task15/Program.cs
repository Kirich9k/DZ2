Console.Clear();
Console.Write("Введите число, обозначающий день недели чтобы увидеть является ли этот день выходным: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5)
    Console.Write("Да, это выходной день");
else
    while (n < 1 || n > 7) {
        Console.Write("Число не обозначает день недели!\nВведите число, обозначающее день недели: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Нет, это будний день");