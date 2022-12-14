Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int secondMax = 0;
while (n != 0){
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max){
        secondMax = max;
        max = n;
    }
    else if (n > secondMax && n < max){
        secondMax = n;
    }
}
Console.WriteLine("End");
Console.WriteLine();
Console.WriteLine($"Second Max={secondMax}");