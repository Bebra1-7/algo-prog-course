Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine("");
byte maxByte = 255;
byte over = (byte)(maxByte + 1);
Console.WriteLine(over);

Console.WriteLine("");
char Letter = 'C';
char separ = '-';
int Num = Letter;

Console.WriteLine($"{Letter} .... {separ}");
Console.WriteLine($"{Letter} ..... {Num}");

Console.WriteLine("");
double doub = 0.1 + 0.2;
decimal deci = 0.1m + 0.2m;
Console.WriteLine($"{doub}");
Console.WriteLine($"{deci}");

Console.WriteLine("");
var age = 20;
var gpa = 4.75;
var name = "Smirnov";
Console.WriteLine($"{name} .... {age} .... {gpa}");

Console.WriteLine("");
Console.Write("Введите имя:");
string ttt = Console.ReadLine();
Console.Write("Введите возраст:");
int rrr = Convert.ToInt32(Console.ReadLine());// or int.Parse(Console.ReadLine()

string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"{wasSuccessful}");
Console.WriteLine($"{booksCount}");