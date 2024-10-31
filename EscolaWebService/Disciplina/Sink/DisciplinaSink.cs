using System.Xml.Linq;

namespace EscolaWebService.Disciplina.Sink;

public class DisciplinaSink
{
    public void SaveData(XDocument xmlDoc)
    {
        xmlDoc.Save("disciplinas.xml");
    }
}