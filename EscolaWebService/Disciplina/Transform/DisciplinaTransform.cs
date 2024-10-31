using System.Xml.Linq;
using EscolaWebService.Disciplina.Model;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Disciplina.Transform;

public class DisciplinaTransform : ITransform
{
    public XDocument ConvertData(List<IModel> data)
    {
        var disciplinas = data.Cast<DisciplinaModel>().ToList();
        XDocument xmlDoc = new XDocument(new XElement("Disciplinas",
            disciplinas.Select(disciplina => new XElement("Disciplina",
                new XElement("Id", disciplina.Id),
                new XElement("Nome", disciplina.Nome),
                new XElement("Descricao", disciplina.Descricao)
            ))
        ));
        
        return xmlDoc;
    }
}