using System.Xml.Linq;
using EscolaWebService.Domain.Escola.Aluno.Model;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Aluno.Transform
{
    public class AlunoTransform : ITransform
    {
        public XDocument ConvertData(List<IModel> data)
        {
            var alunos = data.Cast<AlunoModel>().ToList();
            XDocument xmlDoc = new XDocument(new XElement("Alunos",
                alunos.Select(aluno => new XElement("Aluno",
                    new XElement("Id", aluno.Id),
                    new XElement("Nome", aluno.Nome),
                    new XElement("Endereco", aluno.Endereco)
                ))
            ));

            return xmlDoc;
        }
    }
}