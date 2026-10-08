Console.WriteLine("Введите первую сторону: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую сторону:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите третью сторону: ");
double c = double.Parse(Console.ReadLine());

double P = a + b + c;
double p = P/2.0;
double S = Math.Sqrt(p*(p - a)*(p - b)*(p - c));


Console.WriteLine ($"Периметр: {P}");
Console.WriteLine ($"Площадь: {S:F2}");

