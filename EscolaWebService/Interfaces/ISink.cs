using System.Xml.Linq;

namespace EscolaWebService.Interfaces;

public interface ISink
{
    void SaveData(XDocument xmlDoc);
}