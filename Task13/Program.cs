Console.Clear();
Console.Write("Введите число, чтобы увидеть его третью цифру: ");
long digit = Convert.ToInt64(Console.ReadLine());
string digitForRazryad = Convert.ToString(digit);
long razryad = digitForRazryad.Length;
long stepen = Convert.ToInt64(Math.Pow(10, razryad - 3));
if (digit >= 100)
    Console.WriteLine($"{(digit / stepen) % 10}");
else
    Console.WriteLine("У числа нет третьей цифры");