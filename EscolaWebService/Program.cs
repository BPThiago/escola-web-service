using System.Xml.Linq;
using EscolaWebService.Domain.Enums;
using EscolaWebService.Domain.Escola.Aluno.Sink;
using EscolaWebService.Domain.Escola.Aluno.Source;
using EscolaWebService.Domain.Escola.Aluno.Transform;
using EscolaWebService.Domain.Escola.Disciplina.Sink;
using EscolaWebService.Domain.Escola.Disciplina.Source;
using EscolaWebService.Domain.Escola.Disciplina.Transform;
using EscolaWebService.Domain.Escola.Matricula.Sink;
using EscolaWebService.Domain.Escola.Matricula.Source;
using EscolaWebService.Domain.Escola.Matricula.Transform;
using EscolaWebService.Factory;
using EscolaWebService.Interfaces;

namespace EscolaWebService
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Initialize factories
            IFactory<ISource> sourceFactory = AbstractEscolaFactory<ISource>.CreateFactory(TipoEtapa.Source);
            IFactory<ITransform> transformFactory = AbstractEscolaFactory<ITransform>.CreateFactory(TipoEtapa.Transform);
            IFactory<ISink> sinkFactory = AbstractEscolaFactory<ISink>.CreateFactory(TipoEtapa.Sink);
            
            // Source - Retrieve JSON data from API
            ISource alunoSource = sourceFactory.Create(TipoEntidade.Aluno);
            ISource disciplinaSource = sourceFactory.Create(TipoEntidade.Disciplina);
            ISource matriculaSource = sourceFactory.Create(TipoEntidade.Matricula);
            
            List<IModel> listaAlunos = alunoSource.GetData();
            List<IModel> listaDisciplinas = disciplinaSource.GetData();
            List<IModel> listaMatriculas = matriculaSource.GetData();
            
            // Transform - Transform objects into XML
            ITransform alunoTransform = transformFactory.Create(TipoEntidade.Aluno);
            ITransform disciplinaTransform = transformFactory.Create(TipoEntidade.Disciplina);
            ITransform matriculaTransform = transformFactory.Create(TipoEntidade.Matricula);
            
            XDocument alunoXml = alunoTransform.ConvertData(listaAlunos);
            XDocument disciplinaXml = disciplinaTransform.ConvertData(listaDisciplinas);
            XDocument matriculaXml = matriculaTransform.ConvertData(listaMatriculas);
            
            // Sink - Save XMLs
            ISink alunoSink = sinkFactory.Create(TipoEntidade.Aluno);
            ISink disciplinaSink = sinkFactory.Create(TipoEntidade.Disciplina);
            ISink matriculaSink = sinkFactory.Create(TipoEntidade.Matricula);
            
            alunoSink.SaveData(alunoXml);
            disciplinaSink.SaveData(disciplinaXml);
            matriculaSink.SaveData(matriculaXml);
        }
    }
}