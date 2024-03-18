using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Balta.ContextoConteudo;
using Balta.ContextoNotificacao;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo sobre POO", "orientacao-objeto"));
            artigos.Add(new Artigo("Artigo sobre C#", "csharp"));
            artigos.Add(new Artigo("Artigo sobre .Net", "dotnet"));

            //foreach(var artigo in artigos)
            //{
            //    Console.WriteLine(artigo.Id);
            //    Console.WriteLine(artigo.Titulo);
            //    Console.WriteLine(artigo.Url);
            //}

            var curso = new List<Curso>();
            var cursoPOO = new Curso("Fundamentos POO", "fundamentos-poo");
            var cursoCSharp = new Curso("Fundamentos POO", "fundamentos-csharp");
            var cursoAspNet = new Curso("Fundamentos POO", "fundamentos-aspnet");

            curso.Add(cursoPOO);
            curso.Add(cursoCSharp);
            curso.Add(cursoAspNet);

            var carreiras = new List<Carreira>();
            var carreiraDotNet = new Carreira("Especialista .Net", "especialista-dotnet");
            var itemCarreira2 = new ItemCarreira(2, "Aprenda POO", "", null);
            var itemCarreira = new ItemCarreira(1, "Comece por aqui", "", cursoCSharp);
            var itemCarreira3 = new ItemCarreira(3, "Aprenda .Net", "", cursoAspNet);

            carreiraDotNet.Items.Add(itemCarreira2);
            carreiraDotNet.Items.Add(itemCarreira3);
            carreiraDotNet.Items.Add(itemCarreira);

            carreiras.Add(carreiraDotNet);

            foreach(var carreira in carreiras)
            {
                Console.WriteLine(carreira.Titulo);
                foreach(var item in carreira.Items.OrderBy(x=>x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                    Console.WriteLine(item.Curso?.Titulo);
                    Console.WriteLine(item.Curso?.Nivel);

                    foreach(var notificacao in item.Notificacoes)
                    {
                        Console.WriteLine($"{notificacao.Propriedade} - {notificacao.MensagemErro}");
                    }
                }
            }

        }
    }
}

