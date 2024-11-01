using EscolaWebService.Domain.Escola.Matricula.Model;
using EscolaWebService.Interfaces;
using EscolaWebService.Repository;
using Newtonsoft.Json;

namespace EscolaWebService.Domain.Escola.Matricula.Source;

public class MatriculaSource : ISource
{
    private string _url = "matriculas";

    public List<IModel> GetData()
    {
        HttpClientService service = HttpClientService.Instance;
        string jsonData = service.RetrieveData(_url).Result;
        List<MatriculaModel> matriculas = JsonConvert.DeserializeObject<List<MatriculaModel>>(jsonData);
        return matriculas.Cast<IModel>().ToList();
    }
}