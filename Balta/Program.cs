using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Balta.ContextoConteudo;

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

            foreach(var artigo in artigos)
            {
                Console.WriteLine(artigo.Id);
                Console.WriteLine(artigo.Titulo);
                Console.WriteLine(artigo.Url);
            }

        }
    }
}

