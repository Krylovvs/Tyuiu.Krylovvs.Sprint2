using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task4.V15.Lib;

int x = 4, y = 9;
DataService Examp = new DataService();
double Res = Examp.Calculate(x, y);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Тернарный оператор"},
    {"{{QUEST_NUM}}","4"},
    {"{{VAR_NUM}}","15"},
    {"{{CONDITIONS}}","Написать программу, которая вычисляет" +
    "требуемое значение использованием тетрарного оператора," +
    "где пользователь вводит значение переменных x,y"},
    {"{{ENTER_DATA1_ARRAY}}","x = 4, y = 9"},
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

