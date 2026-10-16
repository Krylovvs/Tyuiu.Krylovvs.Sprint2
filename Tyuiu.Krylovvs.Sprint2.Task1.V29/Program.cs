using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task1.V29.Lib;

int x = 185, y = 251;
DataService Examp = new DataService();
bool[] Res = Examp.GetCompareOperations(x, y);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Операции сравнения"},
    {"{{QUEST_NUM}}","0"},
    {"{{VAR_NUM}}","8"},
    {"{{CONDITIONS}}","Написать программу из операций сравнений (==, !=, <, >, <=, >=, " +
    "последовательность операций не должна нарушаться) и арифметических выражений, " +
    "которая вернет логическую последовательность(массив): " +
    "(True, False, True, False, True, False), при x = 185, y = 251"},
    {"{{ENTER_DATA1_ARRAY}}","x = 185, y = 251"},
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

