using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task1.V29.Lib;

int a = 657, b = 654, c = 657, d = 657;
DataService Examp = new DataService();
bool[] Res = Examp.GetLogicOperations(a, b, c, d);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Логические операции"},
    {"{{QUEST_NUM}}","1"},
    {"{{VAR_NUM}}","29"},
    {"{{CONDITIONS}}","Написать программу из операций сравнений" +
    " (==, !=, <, >, <=, >=, последовательность можно чередовать," +
    " но использовать один раз в выражении) и логических операций " +
    "(|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)," +
    " а также арифметических выражений, которая вернет логическую последовательность(массив):" +
    " (True, True, True, False, True, True), при a = 657, b = 654, c = 657, d = 657"},
    {"{{ENTER_DATA1_ARRAY}}","a = 657, b = 654, c = 657, d = 657"},
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

