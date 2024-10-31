using System.Xml.Linq;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Disciplina.Sink;

public class DisciplinaSink : ISink
{
    public void SaveData(XDocument xmlDoc)
    {
        xmlDoc.Save("disciplinas.xml");
    }
}