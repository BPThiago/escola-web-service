using EscolaWebService.Domain.Enums;

namespace EscolaWebService.Interfaces;

public interface IFactory<T>
{
    public T Create(TipoEntidade tipoEtapa);
}