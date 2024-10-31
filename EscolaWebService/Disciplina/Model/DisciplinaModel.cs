using EscolaWebService.Interfaces;

namespace EscolaWebService.Disciplina.Model
{
    public class DisciplinaModel : IModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        
        public IModel Clone() => (DisciplinaModel)MemberwiseClone();
    }
}