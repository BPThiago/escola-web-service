using System.Xml.Linq;
using EscolaWebService.Domain.Escola.Disciplina.Model;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Disciplina.Transform;

public class DisciplinaTransform : ITransform
{
    public XDocument ConvertData(List<IModel> data)
    {
        var xmlElements = new List<XElement>();
        foreach (IModel disciplina in data)
        {
            DisciplinaModel disciplinaClone = (DisciplinaModel) disciplina.Clone();
            xmlElements.Add(
                new XElement("Disciplina",
                    new XElement("Id", disciplinaClone.Id),
                    new XElement("Nome", disciplinaClone.Nome),
                    new XElement("Descricao", disciplinaClone.Descricao)
                    )
                );
        }
        XDocument xmlDoc = new XDocument(new XElement("Disciplinas",
            xmlElements
        ));
        
        return xmlDoc;
    }
}