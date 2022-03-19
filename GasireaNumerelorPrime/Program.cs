int n = int.Parse(Console.ReadLine());
#pragma warning disable CS8602 // Dereference of a possibly null reference.
string[] data = Console.ReadLine().Split(' ');
#pragma warning restore CS8602 // Dereference of a possibly null reference.
int[] v = new int[n];

Console.Write("Numere prime din sirul introdus: ");
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(data[i]);
    if (IsPrim(v[i]))
        Console.Write(v[i] + " ");

}

static bool IsPrim(int n)
{
    if (n < 2)
        return false;
    if (n == 2)
        return true;
    if (n % 2 == 0)
        return false;
    for (int i = 3; i * i <= n; i += 2)
    {
        if (n % i == 0)
            return false;
    }
    return true;   //true ->nr e prim, false-> nr nu este prim
}