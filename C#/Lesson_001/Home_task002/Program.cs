int number_a = 22;
int number_b = 3;
int number_c = 9;
int max = number_a;
if (number_a > max) max = number_a;
if (number_b > max) max = number_b;
if (number_c > max) max = number_c;
Console.Write("max=");
Console.WriteLine(max);
