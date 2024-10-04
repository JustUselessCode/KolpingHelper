using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using KolpingHelper.Functionality.Entities;

namespace KolpingHelper.Functionality.Helper;

class FileHelper
{
    public static List<string> ReadCsvFileToMemory(string Path) 
    {
        var ReadLines = new List<string>();
        
        if (!File.Exists(Path)) 
        {
            throw new FileNotFoundException("The specified File could not be found!");
        }

        using var csvReader = new StreamReader(new FileStream(Path, FileMode.Open));

        while (!csvReader.EndOfStream)
        {
            var line = csvReader.ReadLine();
            if (line is not null)
            {
                ReadLines.Add(line);
            }
        }

        return ReadLines;
    }

    public static void CreateNewCsvFileForCurrentDirectory(CustomFileInfo _Info)
    {
        using var stream = File.Create(_Info.ToFullPath());
        using var writer = new StreamWriter(stream);


    }
}
