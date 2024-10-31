using System.Xml.Linq;
using EscolaWebService.Aluno.Sink;
using EscolaWebService.Aluno.Source;
using EscolaWebService.Aluno.Transform;
using EscolaWebService.Disciplina.Sink;
using EscolaWebService.Disciplina.Source;
using EscolaWebService.Disciplina.Transform;
using EscolaWebService.Interfaces;
using EscolaWebService.Matricula.Sink;
using EscolaWebService.Matricula.Source;
using EscolaWebService.Matricula.Transform;

namespace EscolaWebService
{
    class Program
    {
        public static void Main(string[] args)
        {
            AlunoSource alunoSource = new AlunoSource();
            DisciplinaSource disciplinaSource = new DisciplinaSource();
            MatriculaSource matriculaSource = new MatriculaSource();
            List<IModel> listaAlunos = alunoSource.GetData();
            List<IModel> listaDisciplinas = disciplinaSource.GetData();
            List<IModel> listaMatriculas = matriculaSource.GetData();
            
            AlunoTransform alunoTransform = new AlunoTransform();
            XDocument alunoXml = alunoTransform.ConvertData(listaAlunos);
            AlunoSink alunoSink = new AlunoSink();
            alunoSink.SaveData(alunoXml);
            
            DisciplinaTransform disciplinaTransform = new DisciplinaTransform();
            XDocument disciplinaXml = disciplinaTransform.ConvertData(listaDisciplinas);
            DisciplinaSink disciplinaSink = new DisciplinaSink();
            disciplinaSink.SaveData(disciplinaXml);
            
            MatriculaTransform matriculaTransform = new MatriculaTransform();
            XDocument matriculaXml = matriculaTransform.ConvertData(listaMatriculas);
            MatriculaSink matriculaSink = new MatriculaSink();
            matriculaSink.SaveData(matriculaXml);
        }
    }
}