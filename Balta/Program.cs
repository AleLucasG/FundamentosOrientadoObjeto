using System;
using System.Runtime.InteropServices;
using Balta.ContextoConteudo;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var curso = new Curso();

            curso.Nivel = ContextoConteudo.Enumeradores.ENivelConteudo.Fundamental;
            
            foreach (var item in curso.Modulos)
            {

            }
            
            // faz a contagem da classe Carreira
            var carreira = new Carreira();
            carreira.Items.Add(new ItemCarreira());
            Console.WriteLine(carreira.TotalCursos);

        }
    }
}

