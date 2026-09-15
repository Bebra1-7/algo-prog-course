// If_Else
// int score = 1200;
// if (score >= 500)
// {
//     Console.WriteLine("Новичек");//Можно убрать {}, если только один блок кода

// }
// else if (score >= 1000)
// {
//     Console.WriteLine("Боец");
// }
// else if (score >= 3000)
// {
//     Console.WriteLine("Мутант");
// }
// else
// {
//     Console.WriteLine("Доступ закрыт");
// }

// Console.WriteLine("Игра продолжается");

// int movieNumber = int.Parse(Console.ReadLine());

// string movieGenre;

// switch (movieNumber)
// {
//     case 1:
//         movieGenre = "Боевик";
//         break;
//     case 2:
//         movieGenre = "Комедия";
//         break;
//     default:
//         movieGenre = "Неизвест. жанр";
//         break;
// }
// Console.WriteLine(movieNumber);

// int score = 3000;
// int recordScore = 3000;
// string result = (score > recordScore) ? "New record" : "Common result";//Тирнарный оператор
// if (score > recordScore)
// {
//     result = "New record";
// }
// else
// {
//     result = "Common result";
// }
// Console.WriteLine(result);

// Вариант 9
Console.Write("Введите ( КН или НБ и т. д. (т. е. К-Камень, Н-Ножницы, Б-Бумага)) ");
string Peoples = Console.ReadLine();
Console.WriteLine(Peoples);

string Winner;
switch (Peoples)
{
    case "КН":
        Winner = "Победил первый игрок";
        break;
    case "НБ":
        Winner = "Победил первый игрок";
        break;
    case "БК":
        Winner = "Победил первый игрок";
        break;

    case "НК":
        Winner = "Победил второй игрок";
        break;
    case "БН":
        Winner = "Победил второй игрок";
        break;
    case "КБ":
        Winner = "Победил второй игрок";
        break;

    case "НН":
        Winner = "Ничья";
        break;
    case "КК":
        Winner = "Ничья";
        break;
    case "ББ":
        Winner = "Ничья";
        break;
    default:
        Winner = "Error input";
        break;
}
Console.WriteLine(Winner);