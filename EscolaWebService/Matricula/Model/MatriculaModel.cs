using EscolaWebService.Interfaces;

namespace EscolaWebService.Matricula.Model
{
    public class MatriculaModel : IModel
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
        
        public IModel Clone() => (MatriculaModel)MemberwiseClone();
    }
}