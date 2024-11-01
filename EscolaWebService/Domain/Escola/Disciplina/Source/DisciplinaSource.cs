using EscolaWebService.Domain.Escola.Disciplina.Model;
using EscolaWebService.Interfaces;
using EscolaWebService.Repository;
using Newtonsoft.Json;

namespace EscolaWebService.Domain.Escola.Disciplina.Source;

public class DisciplinaSource : ISource
{
    private string _url = "disciplinas";

    public List<IModel> GetData()
    {
        HttpClientService service = HttpClientService.Instance;
        string jsonData = service.RetrieveData(_url).Result;
        List<DisciplinaModel> disciplinas = JsonConvert.DeserializeObject<List<DisciplinaModel>>(jsonData);
        return disciplinas.Cast<IModel>().ToList();
    }
}