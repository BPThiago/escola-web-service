using EscolaWebService.Domain.Enums;
using EscolaWebService.Domain.Escola.Aluno.Source;
using EscolaWebService.Domain.Escola.Disciplina.Source;
using EscolaWebService.Domain.Escola.Matricula.Source;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Factory;

public class SourceFactory : AbstractEscolaFactory<ISource>
{
    public override ISource Create(TipoEntidade tipoEntidade)
    {
        switch (tipoEntidade)
        {
            case TipoEntidade.Aluno:
                return new AlunoSource();
            case TipoEntidade.Disciplina:
                return new DisciplinaSource();
            case TipoEntidade.Matricula:
                return new MatriculaSource();
            default:
                throw new ArgumentOutOfRangeException(nameof(tipoEntidade), tipoEntidade, null);
        }
    }
}