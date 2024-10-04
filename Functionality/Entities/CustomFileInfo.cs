using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolpingHelper.Functionality.Entities;

class CustomFileInfo
{
    public string Path { get; set; }

    public string Name { get; set; }

    public string FileType { get; set; }

    public CustomFileInfo(string _Path, string _Name, string _FileType)
    {
        Path = _Path;
        Name = _Name;
        FileType = _FileType;
    }

    public string ToFullPath()
    {
        return @$"{Path}\{Name}.{FileType}";
    }
}
