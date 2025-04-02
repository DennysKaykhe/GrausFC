double c;
double f;

Console.Clear();

Console.Write("ºF = ");
f = Convert.ToDouble(Console.ReadLine());

c = (f - 32) / 1.8;

Console.WriteLine($"{f}ºF equivalem a {c}ºC");