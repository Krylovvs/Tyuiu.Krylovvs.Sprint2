using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task7.V1.Lib;

double x, y;

Console.WriteLine("Введите х: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y: ");
y = Convert.ToDouble(Console.ReadLine());

DataService Examp = new DataService();
bool Res = Examp.CheckDotInShadedArea(x, y);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Добавление к решению итоговых проектов по спринту"},
    {"{{QUEST_NUM}}","7"},
    {"{{VAR_NUM}}","1"},
    {"{{CONDITIONS}}","Написать программу на C#, которая запрашивает" +
    " исходные данные (вещественные значения) и вычисляет, находится" +
    " ли точка с координатами X,Y в заштрихованной области."},
    {"{{ENTER_DATA1_ARRAY}}",$"x = {x}, y = {y}"},
    {"{{OUT_DATA_ARRAY}}",string.Join(",",Res)}
};

Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"..\..\..\..\Ender.txt", Encoding.UTF8);

foreach (var i in PlaceHolders)
{
    Text = Text.Replace(i.Key, i.Value);
}

Console.WriteLine(Text);
Console.ReadKey();

