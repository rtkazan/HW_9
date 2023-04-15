Console.Clear();
int m = InputInt("Введите m: ");
int n = InputInt("Введите n: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}