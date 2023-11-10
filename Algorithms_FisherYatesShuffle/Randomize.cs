using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_FisherYatesShuffle
{
    public class Randomize
    {
        public static List<string> FileData = new List<string>();

        Utility util = new Utility(FileData);
        Random rand = new Random();

        public void FisherMethod()
        {
            //Intialize a var equal to the size of the list
            int Num = FileData.Count;

            //Loop as long as Num does not equal 1 
            while (Num > 1)
            {
                //Decrement Num for it is the size of the list's count
                Num--;
                //Intialize a new int that is equal to a number between 0 and the current count size of the list. 
                int Nxt = rand.Next(Num);
                //Take the current index and swap it with the randomly chosen new index
                string value = FileData[Nxt];
                FileData[Nxt] = FileData[Num];
                FileData[Num] = value;
            }

          
        }

        public void FileToConsole()
        {
            foreach (string line in FileData)
            {
                Console.WriteLine(line);
            }
        }


    }
}
