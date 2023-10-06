Random rand = new Random(); 
string path = ($"{Directory.GetCurrentDirectory()}\\files");
var FileList = Directory.GetFiles(path).ToList();
List<string> FileData= new List<string>();


foreach (var file in FileList)
{


    using (StreamReader sr = new StreamReader(file)) //will change due to different PATH ?
    {
        var line = sr.ReadLine();

        while (line != null)
        {

            FileData.Add(line);
            line = sr.ReadLine();


        }
    }
}

Randomize(FileData);

foreach (string line in FileData)
{
    Console.WriteLine(line);
}


void Randomize(List<string> data)
{
    int Num = data.Count;
    while (Num > 1)
    {
        Num--;
        int Nxt = rand.Next(Num + 1);
        string value = data[Nxt];
        data[Nxt] = data[Num];
        data[Num] = value;
    }
}