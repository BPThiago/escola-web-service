using EscolaWebService.Domain.Enums;
using EscolaWebService.Domain.Escola.Aluno.Transform;
using EscolaWebService.Domain.Escola.Disciplina.Transform;
using EscolaWebService.Domain.Escola.Matricula.Transform;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Factory;

public class TransformFactory : AbstractEscolaFactory<ITransform>
{
    public override ITransform Create(TipoEntidade tipoEntidade)
    {
        switch (tipoEntidade)
        {
            case TipoEntidade.Aluno:
                return new AlunoTransform();
            case TipoEntidade.Disciplina:
                return new DisciplinaTransform();
            case TipoEntidade.Matricula:
                return new MatriculaTransform();
            default:
                throw new ArgumentOutOfRangeException(nameof(tipoEntidade), tipoEntidade, null);
        }
    }
}