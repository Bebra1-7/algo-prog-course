using System.Data;
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

Console.WriteLine($"Табуляция: \tпосле таба");
Console.WriteLine($"Перенос: \nпосле переноса");

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

Console.WriteLine();
Console.Write("Введ. Имя и фам.");
string names = Console.ReadLine();

Console.Write("Введ. группу");
string group = Console.ReadLine();

Console.Write("Введ. год рожд.");
int good = Convert.ToInt32(Console.ReadLine());

Console.Write("Введ. ср. балл");
string bal = Console.ReadLine();

bool ball = int.TryParse(bal, out int ggg);

Console.Write("Введ. любим. буква");
string buk = Console.ReadLine();
char t = '\t';
Console.WriteLine($"{t} Анкета");

Console.WriteLine($"{names}, группа {group}");
Console.WriteLine($"Год рождения: {good}");
Console.WriteLine($"Ср. балл: {bal}");
Console.WriteLine($"Балл >= 4.0: {ball}");
Console.WriteLine($"Любим. буква {buk}");
//Задание 1
Console.Write("Рост: ");
double line = Convert.ToDouble(Console.ReadLine());
Console.Write("Вес: ");
double weight = Convert.ToDouble(Console.ReadLine());
double IMT = weight / (line * line);
Console.WriteLine($"ИМТ: {IMT:F2}");
//Задание 2
Console.Write("Фамилия: ");
string Surname = Console.ReadLine();
Console.Write("Имя: ");
string Name = Console.ReadLine();
Console.WriteLine($"{Surname} {Name[0]}.");
//Задание 3

bool inumber = int.TryParse(Console.ReadLine(), out int int_num);
bool dnumber = double.TryParse(Console.ReadLine(), out double doub_num);
bool time = DateTime.TryParse(Console.ReadLine(), out DateTime t_num);
Console.WriteLine($"int {inumber} {int_num}");
Console.WriteLine($"double {dnumber} {doub_num}");
Console.WriteLine($"time {time} {t_num}");
