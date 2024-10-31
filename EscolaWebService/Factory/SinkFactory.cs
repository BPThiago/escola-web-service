using EscolaWebService.Domain.Enums;
using EscolaWebService.Domain.Escola.Aluno.Sink;
using EscolaWebService.Domain.Escola.Disciplina.Sink;
using EscolaWebService.Domain.Escola.Matricula.Sink;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Factory;

public class SinkFactory : AbstractEscolaFactory<ISink>
{
    public override ISink Create(TipoEntidade tipoEntidade)
    {
        switch (tipoEntidade)
        {
            case TipoEntidade.Aluno:
                return new AlunoSink();
            case TipoEntidade.Disciplina:
                return new DisciplinaSink();
            case TipoEntidade.Matricula:
                return new MatriculaSink();
            default:
                throw new ArgumentOutOfRangeException(nameof(tipoEntidade), tipoEntidade, null);
        }
    }
}