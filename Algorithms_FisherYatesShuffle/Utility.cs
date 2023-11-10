using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms_FisherYatesShuffle
{
    public class Utility
    {

       
        public Utility(List<string> fileData) 
        {        
            AddFileData(fileData);
        }


        List<string> AddFileData(List<string> FileData)
        {
            //Sets Path to Directory and accesses files folder
            string path = ($"{Directory.GetCurrentDirectory()}\\files");
            //Puts any files inside of file folder into a list
            var FileList = Directory.GetFiles(path).ToList();
            

            foreach (var file in FileList)
            {

                //Reads into the current file
                using (StreamReader sr = new StreamReader(file))
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
            return FileData;
        }

        
            
    }
}


    

