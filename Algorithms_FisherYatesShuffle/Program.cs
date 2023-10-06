Random rand = new Random();
//Sets Path to Directory
string path = ($"{Directory.GetCurrentDirectory()}\\files");
var FileList = Directory.GetFiles(path).ToList();
List<string> FileData= new List<string>();

//loops through all files in File List
foreach (var file in FileList)
{


    using (StreamReader sr = new StreamReader(file)) //will change due to different PATH ?
    {
        var line = sr.ReadLine();

        while (line != null)
        {
            //Add file data to list
            FileData.Add(line);
            line = sr.ReadLine();


        }
    }
}

//Calls method that implements fisher yates algorithm
Randomize(FileData);

foreach (string line in FileData)
{
    Console.WriteLine(line);
}


void Randomize(List<string> data)
{
    //Intialize a var equal to the size of the list
    int Num = data.Count;

    //Loop as long as Num does not equal 1 
    while (Num > 1)
    {
        //Decrement Num for it is the size of the list's count
        Num--;
        //Intialize a new int that is equal to a number between 0 and the current count size of the list. 
        int Nxt = rand.Next(Num);
        //Take the current index and swap it with the randomly chosen new index
        string value = data[Nxt];
        data[Nxt] = data[Num];
        data[Num] = value;
    }
}