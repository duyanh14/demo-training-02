using System.Collections;

Dictionary<string, int> studentScore = new Dictionary<string, int>();
studentScore.Add("Duy Anh", 8);
studentScore.Add("Minh", 10);

foreach (var item in studentScore)
{
    Console.WriteLine("Name {0} score {1}", item.Key, item.Value);
}

Hashtable ht = new Hashtable(studentScore);

foreach (DictionaryEntry item in ht)
{
    Console.WriteLine("Name {0} score {1}", item.Key, item.Value);
}

Stack<int> months = new Stack<int>();
months.Push(1);
months.Push(2);
months.Push(3);
months.Push(4);
months.Push(5);
months.Push(6);
months.Push(7);
months.Push(8);
months.Push(9);
months.Push(10);
months.Push(11);
months.Push(12);

foreach (var item in months)
    Console.Write(item + ",");

Queue<string> name = new Queue<string>();
name.Enqueue("D");
name.Enqueue("u");
name.Enqueue("y");
name.Enqueue(" ");
name.Enqueue("A");
name.Enqueue("n");
name.Enqueue("h");

while (name.Count > 0)
    Console.WriteLine(name.Dequeue());

var studentIndex = Tuple.Create("Duy Anh", "Minh", "Tan");
Console.WriteLine(studentIndex.Item1);

var studentIndex2 = ("Duy Anh", "Minh", "Tan");
Console.WriteLine(studentIndex2.Item1);
