using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task3.V3.Lib;

double x = 2;
DataService Examp = new DataService();
double Res = Examp.Calculate(x);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Вложенные операторы if-else"},
    {"{{QUEST_NUM}}","3"},
    {"{{VAR_NUM}}","3"},
    {"{{CONDITIONS}}","Написать программу, " +
    "которая вычисляет требуемое значение функции Y " +
    "с использованием вложенных оператор if-else, " +
    "где пользователь вводит значение переменной X с " +
    "клавиатуры. Округлить полученное значение " +
    "до трех знаков после запятой;"},
    {"{{ENTER_DATA1_ARRAY}}","x = 2"},
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

