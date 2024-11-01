using System.Xml.Linq;
using EscolaWebService.Domain.Escola.Aluno.Model;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Aluno.Transform
{
    public class AlunoTransform : ITransform
    {
        public XDocument ConvertData(List<IModel> data)
        {
            var xmlElements = new List<XElement>();
            foreach (IModel aluno in data)
            {
                AlunoModel alunoClone = (AlunoModel) aluno.Clone();
                xmlElements.Add(
                    new XElement("Aluno",
                        new XElement("Id", alunoClone.Id),
                        new XElement("Nome", alunoClone.Nome),
                        new XElement("Endereco", alunoClone.Endereco)
                    )
                );
            }
            XDocument xmlDoc = new XDocument(new XElement("Alunos",
                xmlElements
            ));

            return xmlDoc;
        }
    }
}