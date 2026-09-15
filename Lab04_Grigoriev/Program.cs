using System.Threading.Tasks.Dataflow;

int score = 1200;
if (score >= 500)
{
    Console.WriteLine("Новичек");//Можно убрать {}, если только один блок кода

}
else if (score >= 1000)
{
    Console.WriteLine("Боец");
}
else if (score >= 3000)
{
    Console.WriteLine("Мутант");
}
// else
// {
//     Console.WriteLine("Доступ закрыт");
// }

Console.WriteLine("Игра продолжается");

