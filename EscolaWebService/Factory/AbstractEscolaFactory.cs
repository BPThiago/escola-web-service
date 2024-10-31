using EscolaWebService.Domain.Enums;
using EscolaWebService.Interfaces;

namespace EscolaWebService.Factory
{
    public abstract class AbstractEscolaFactory<T> : IFactory<T>
    {
        public abstract T Create(TipoEntidade tipoEntidade);
        
        public static IFactory<T> CreateFactory(TipoEtapa tipoEtapa)
        {
            switch (tipoEtapa)
            {
                case TipoEtapa.Source:
                    return (IFactory<T>) new SourceFactory();
                case TipoEtapa.Transform:
                    return (IFactory<T>) new TransformFactory();
                case TipoEtapa.Sink:
                    return (IFactory<T>) new SinkFactory();
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoEtapa), tipoEtapa, null);
            }
        }
    }
}