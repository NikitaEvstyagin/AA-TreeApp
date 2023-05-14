using AA_TreeApp;
using System.Diagnostics;
using System.Text;


//AATree<int> tree = new AATree<int>();
//tree.Add(1);
//tree.Add(2);

//tree.Add(6);
//tree.Add(10);
//tree.Add(5);

//tree.PrintTree();



/*FileInfo file;
var r = new Random();

file = new FileInfo($@"C:\С#\10000.txt");
var stringpoint = new StringBuilder();
for (int j = 0; j < 10000; j++)
{
    if (j == 9999)
    {
        stringpoint.Append($"{r.Next(0, 1000)}");
        break;
    }
    stringpoint.Append($"{r.Next(0, 1000)} ");
}

using (var sw = file.AppendText())
{
    sw.WriteLine(stringpoint.ToString());
}*/

string numbers;
numbers = File.ReadAllText($@"C:\С#\10000.txt");
List<int> kit = new();
foreach (var p in numbers.Split(" "))
{
    if (p.Contains("-"))
        kit.Add(-Convert.ToInt32(p));
    kit.Add(Convert.ToInt32(p));
}


int[] arr = kit.ToArray();


AATree<int> tree = new AATree<int>();


for (int i = 0; i < arr.Length; i++)
{
    var time = new Stopwatch();
    time.Start();
    tree.Add(arr[i]);
    time.Stop();
    Console.WriteLine($"{arr[i]}, {time.Elapsed}, {tree.iteration}");
}

//Console.WriteLine();

//for (int i = 0; i < 100; i++)
//{
//    var r = new Random();
//    var c = arr[r.Next(0, 10000)];
//    var time = new Stopwatch();
//    time.Start();
//   tree.Search(c);
//   time.Stop();
//    Console.WriteLine($"{c}, {time.Elapsed}, {tree.iteration}");
//}

//Console.WriteLine();

//for (int i = 0; i < 1000; i++)
//{
//    var r = new Random();
//    var c = arr[r.Next(0, 10000)];
//    var time = new Stopwatch();
//    time.Start();
//    tree.Remove(c);
//    time.Stop();
//    Console.WriteLine($"{c}, {time.Elapsed}, {tree.iteration}");
//}