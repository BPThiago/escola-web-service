using EscolaWebService.Domain.Escola.Aluno.Model;
using EscolaWebService.Interfaces;
using EscolaWebService.Repository;
using Newtonsoft.Json;

namespace EscolaWebService.Domain.Escola.Aluno.Source;

public class AlunoSource : ISource
{
    private string _url = "alunos";

    public List<IModel> GetData()
    {
        HttpClientService service = HttpClientService.Instance;
        string jsonData = service.RetrieveData(_url).Result;
        List<AlunoModel> alunos = JsonConvert.DeserializeObject<List<AlunoModel>>(jsonData);
        return alunos.Cast<IModel>().ToList();
    }
}