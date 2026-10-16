using System.Runtime.Serialization.Formatters;
using System.Text;
using Tyuiu.Krylovvs.Sprint2.Task2.V19.Lib;

int x = 15, y = 15;
DataService Examp = new DataService();
bool Res = Examp.CheckDotInShadedArea(x, y);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Оператор if – полная и короткая форма записи"},
    {"{{QUEST_NUM}}","2"},
    {"{{VAR_NUM}}","19"},
    {"{{CONDITIONS}}","Написать программу на, которая запрашивает " +
    "целые значения с клавиатуры и вычисляет находится ли точка с" +
    " координатами X,Y в заштрихованной области."},
    {"{{ENTER_DATA1_ARRAY}}","x = 15, y = 15"},
    {"{{OUT_DATA_ARRAY}}",string.Join(",",Res)}
};

Console.Title = "Спринт #1 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"..\..\..\..\Ender.txt", Encoding.UTF8);

foreach (var i in PlaceHolders)
{
    Text = Text.Replace(i.Key, i.Value);
}

int[,] Arr = new int[15, 15];

for(int a = 0; a < 15; a++)
{
    for (int b = 0; b < 15; b++)
    {
        Arr[a, b] = 0;
        if (Examp.CheckDotInShadedArea(a, b))
        {
            Arr[a, b] = 1;
        }
    }
}

Console.WriteLine(Text);

for (int row = 0; row < Arr.GetLength(0); row++)
{
    for (int column = 0; column < Arr.GetLength(1); column++)
    {
        Console.Write(Arr[row, column] + "\t");
    }

    Console.WriteLine();
}
;

Console.ReadKey();

