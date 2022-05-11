using System.Text;

var cat = new { name = "Doja", age = 11 };
dynamic catBirthYear = 2022-cat.age;

StringBuilder sb = new StringBuilder("Chu meo ten la ");
sb.Append(cat.name);
sb.AppendLine();
sb.Append(cat.age.ToString());
sb.Append(" tuoi");
sb.AppendLine();
sb.Append("Sinh "+ "nam ");
sb.Append(catBirthYear);

Console.WriteLine(sb);

Doja dj = new Doja(11);
dj = new Doja() { age = 11};
dj.showAge();
Doja.hello();

interface Cat
{
    void showAge();
    void setAge(int text);
}

class Doja : Cat
{
    public int age = 0;

    public Doja()
    {

    }

    // Constructor
    public Doja(int age)
    {
        this.age = age;
    }

    // Static method
    public static void hello()
    {
        Console.WriteLine("Hello");
    }

    public void showAge()
    {
        Console.WriteLine(this.age);
    }

    public void setAge(int age)
    {
        this.age = age;
    }
}
