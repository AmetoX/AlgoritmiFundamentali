int cf = 2;
if (prim(cf))
    Console.WriteLine(cf + " este prim");
int m = 3131;
if(ispalidrom(m))
    Console.WriteLine(m + " este palindrom");


//se da un vector , sa introduceti valorea 1 dupa fiecare nr perfect 
//numar perfect: nr care are suma divizorilor egala cu 2 ori nr 
//ex: 6 = 1+2+3
Random rd =new Random();
int n = 10;
int[] v = new int[100];
for (int i = 0; i < n; i++)
    v[i] = rd.Next(1000);
for(int i = 0; i < n; i++)
    Console.Write(v[i]+" ");
for (int i = 0; i < n; i++)
{
    Console.Write(v[i] + " ");
    if (nrperfect(v[i]))
        Console.Write("-1 ");
}


static bool prim(int pr)
{
    if(pr<2)
        return false;
    if(pr==2)
        return true; 
    if(pr%2==0)
        return false;
    //i <= Math.Sqrt(pr)
    for (int i = 0; i*i<=pr; i += 2)
        if (pr % i == 0)
            return false;
    return true;
}
static bool CifreEgala(int n)
{

    int pc = n % 10;
    while(n>10)
        n=n/10;
    if (pc == n)
        return true;
    return false;
}
static bool ispalidrom(int n)
{
    int og = 0;
    int aux = n;
    while (n != 0)
        og = og * 10 + n % 10;
        n /= 10;
    if (og == aux)
        return true;
    return false;
}
static bool nrperfect(int n)
{
    //vedem daca nr este perfect sau nu
    int s = 1 + n;
    for (int i = 2; i <= n / 2; i++)
        if (n % i == 0)
            s += i;
    if (s == 2 * n)
        return true;
    return false;
}
 