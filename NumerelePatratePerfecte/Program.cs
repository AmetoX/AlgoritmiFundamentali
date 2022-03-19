//Se da un vector, sa introduceti valoarea 1 dupa fiecare numar perfect
// numar perfect = numarul care are suma divizorilor egala cu 2 ori numarul
// ex: 6 = 1 + 2 + 3
Random rnd = new Random();
int n = 10000;

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = rnd.Next(1000000);

}
for (int i = 0; i < n; i++)
{
    Console.Write(v[i] + " ");
    if (NrPerfect(v[i])) Console.Write("-1 ");
}

static bool NrPerfect(int n)
{
    if (n == 6 || n == 28 || n == 496 || n == 8128)
        return true;
    return false;
}