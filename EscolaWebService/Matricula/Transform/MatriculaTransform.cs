using System.Xml.Linq;
using EscolaWebService.Interfaces;
using EscolaWebService.Matricula.Model;

namespace EscolaWebService.Matricula.Transform
{
    public class MatriculaTransform : ITransform
    {
        public XDocument ConvertData(List<IModel> data)
        {
            var matriculas = data.Cast<MatriculaModel>().ToList();
            XDocument xmlDoc = new XDocument(new XElement("Matriculas",
                matriculas.Select(matricula => new XElement("Matricula",
                    new XElement("Id", matricula.Id),
                    new XElement("AlunoId", matricula.AlunoId),
                    new XElement("DisciplinaId", matricula.DisciplinaId)
                ))
            ));

            return xmlDoc;
        }
    }
}