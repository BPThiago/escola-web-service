using System.Xml.Linq;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Aluno.Sink
{
    public class AlunoSink : ISink
    {
        public void SaveData(XDocument xmlDoc)
        {
            xmlDoc.Save("alunos.xml");
        }
    }
}