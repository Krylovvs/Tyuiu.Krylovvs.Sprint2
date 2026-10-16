using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task6.V11.Lib;

int g = 2021, m = 9, n = 11;
DataService Examp = new DataService();
string Res = Examp.FindDateOfNextDay(g, m, n);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Получение результата из switch"},
    {"{{QUEST_NUM}}","6"},
    {"{{VAR_NUM}}","11"},
    {"{{CONDITIONS}}","Дата некоторого дня характеризуется тремя" +
    " натуральными числами: g (год), m (порядковый номер месяца)" +
    " и n (число). По заданным g, n и m определить дату следующего дня. " +
    "Заданный год не является високосным."},
    {"{{ENTER_DATA1_ARRAY}}","g = 2021, m = 9, n = 11"},
    {"{{OUT_DATA_ARRAY}}",Res}
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

