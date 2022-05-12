//Conditions & Loops
using System.Collections;

Console.WriteLine("Conditions");

Console.WriteLine("isTeenager "+isTeenager(20));
colorMatch("Red");

Console.WriteLine("Loops");

Count(10);
Count2(10);
Count3(10);

//Collections
Console.WriteLine("Collections");

string[,] score = new string[2,2]{
    {
        "Duy Anh", "8"
    },
    { 
        "Minh","10" 
    }
};
for (int i = 0; i < score.Rank ; i++)
{
    Console.WriteLine(score[i,0] + " - " + score[i,1]);
}

string[][] score1 = new string[2][]{
    new string[2]{ "Duy Anh","8"},
    new string[2]{ "Minh","10"}
};
for (int i = 0; i < score1.Length ; i++)
{
    Console.WriteLine(score1[i][0] + " - " + score1[i][1]);
}

var score2 = new ArrayList();
score2.Add(new string[]{ "Duy Anh", "8"});
score2.Add(new string[] { "Minh", "10" });
for (int i = 0; i < score2.Count; i++)
{
    object[] sc = score2[i] as object[];
    Console.WriteLine(sc[0]+ " - " + sc[1]);
}

var student = new List<string>();
student.Add("Duy Anh");
student.Add("Minh");
for (int i = 0; i < student.Count; i++)
{
    Console.WriteLine(student[i]);
}

SortedList<int, string> numbers = new SortedList<int, string>()
{
    {3,"Three" },
    {1,"One" },
    {2,"Two" }
};
foreach (var item in numbers)
{
    Console.WriteLine(item.Value);
}

static void Count(int c)
{
    for (int i=1;i<c+1;i++)
    {
        Console.WriteLine(i);
    }
}

static void Count2(int c)
{
    int i = 1;
    while (i <= 10) { 
        Console.WriteLine(i);
        i++;
    }
}

static void Count3(int c)
{
    int i = 1;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 10);
}


static bool isTeenager(int i)
{
    int teenagerAge = 18;
    if (i >= teenagerAge)
    {
        return true;
    } else
    {
        return false;
    }
    //return i >= teenagerAge;
    //return i >= teenagerAge ? true : false;
}

static void colorMatch(string color) {
    switch (color)
    {
        case "Orange":
            Console.WriteLine("Sunset");
            break;
        case "Blue":
            Console.WriteLine("Sky");
            break;
        case "Red":
            Console.WriteLine("Blood");
            break;
        default:
            Console.WriteLine("Unknown");
            break;
    }
}