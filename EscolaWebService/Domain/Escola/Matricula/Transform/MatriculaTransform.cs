using System.Xml.Linq;
using EscolaWebService.Domain.Escola.Matricula.Model;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Domain.Escola.Matricula.Transform
{
    public class MatriculaTransform : ITransform
    {
        public XDocument ConvertData(List<IModel> data)
        {
            var xmlElements = new List<XElement>();
            foreach (IModel matricula in data)
            {
                MatriculaModel matriculaClone = (MatriculaModel) matricula.Clone();
                xmlElements.Add(
                    new XElement("Matricula",
                        new XElement("Id", matriculaClone.Id),
                        new XElement("AlunoId", matriculaClone.AlunoId),
                        new XElement("DisciplinaId", matriculaClone.DisciplinaId)
                    )
                );
            }
            XDocument xmlDoc = new XDocument(new XElement("Matriculas",
                xmlElements
            ));

            return xmlDoc;
        }
    }
}