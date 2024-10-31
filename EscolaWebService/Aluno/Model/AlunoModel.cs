using EscolaWebService.Disciplina.Model;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Aluno.Model
{
    public class AlunoModel : IModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        
        public IModel Clone() => (AlunoModel)MemberwiseClone();
    }
}