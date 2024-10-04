using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolpingHelper.Functionality.Helper;

class StringEditingHelper
{
    public static string RemoveBlanksFromCsvString(string _Col)
    {
        var wsString = new StringBuilder();
        foreach (var character in _Col.Where(c => string.IsNullOrWhiteSpace(c.ToString())))
        {
            wsString.Append(character.ToString());
        }

        return _Col.Replace(wsString.ToString(), " ");
    }

    public static string ReplaceWrongEncodingCharactersWithCorrect(string _Col)
    {
        return _Col.Replace("Ã„", "Ä")
                   .Replace("Ã–", "Ö")
                   .Replace("Ãœ", "Ü")

                   .Replace("Ã¤", "ä")
                   .Replace("Ã¶", "ö")
                   .Replace("Ã¼", "ü")
                   .Replace("ÃŸ", "ß");
    } 
}
