using System.Xml.Linq;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Matricula.Sink
{
    public class MatriculaSink : ISink
    {
        public void SaveData(XDocument xmlDoc)
        {
            xmlDoc.Save("matriculas.xml");
        }
    }
}