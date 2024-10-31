using System.Xml.Linq;

namespace EscolaWebService.Interfaces;

public interface ITransform
{
    XDocument ConvertData(List<IModel> data);
}