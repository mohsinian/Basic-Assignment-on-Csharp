Console.WriteLine("Hello, World!");
int a = 10; bool b = false; char c = 'a'; string s = "tahsin"; long d = long.MaxValue;
Console.WriteLine($"{a} {b} {c} {s} {d}");
string x = "10"; int z = Convert.ToInt32(x);
Console.WriteLine($"{z}");
double w = 10.55; double aa = a; int aaa = (int)w;
Console.WriteLine($"{Convert.ToString(c)} {Convert.ToString(w)} {aa} {aaa} {Convert.ToInt64(c)}");
if (a % 2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}
var decision = a % 2 == 0 ? "even" : "odd";
Console.WriteLine(decision);
var fibs = new List<int> { 1, 1 };
while (fibs.Count < 10)
{
    var prev1 = fibs[fibs.Count - 1];
    var prev2 = fibs[fibs.Count - 2];
    fibs.Add(prev1+prev2);
}
foreach (var y in fibs)
{
    Console.WriteLine(y);
}
for (int i = 1; i <= 100; i++)
{
    if (i == 95) continue;
    if (i == 99) break;
    Console.WriteLine(i);
}
string xx = "hungry";
switch(xx)
{
    case "hungry":
        Console.WriteLine("eat food");
        break;
    case "not hungry":
        Console.WriteLine("dont eat");
        break;
    default: 
        Console.WriteLine("dont waste food");
        break;
}

a = int.MaxValue; a = checked(a + 10);
Console.WriteLine(a);

