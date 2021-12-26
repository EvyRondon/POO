using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      var caminho = "C:\\TrabalhandoComArquivos";
      var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
      var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
      var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
      var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
      var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
      var listaString = new List<string>() { "Linha 1", "Linha 2", "Linha 3" };
      var listaString2 = new List<string>() { "Linha 4", "Linha 5", "Linha 6" };

      FileHelper fh = new FileHelper();
      // fh.ListarDiretorios(caminho);

      // System.Console.WriteLine($"Criando diretório: {caminhoPathCombine}");
      // fh.ListarArquivosDiretorios(caminho);
      // fh.CriarDiretorio(caminhoPathCombine);
      // fh.ApagarDiretorio(caminhoPathCombine, true);
      // fh.CriarArquivoTexto(caminhoArquivo, "Evelym é linda, e a Elisa é filha dela!!!");
      // fh.CriarAquivoStream(caminhoArquivo, listaString);
      // fh.AdicionarTexto(caminhoArquivo, "Euzinha");
      // fh.AdicionarTextoStream(caminhoArquivo, listaString2);
      // fh.LerArquivoStream(caminhoArquivo);
      // fh.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
      // fh.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
      // fh.DeletarArquivo(caminhoArquivoTesteCopia);

      // ICalculadora calc = new Calculadora();
      // System.Console.WriteLine("Resultado da divisão " + calc.Dividir(15, 15));

      // Computador comp = new Computador();
      // System.Console.WriteLine(comp.ToString());

      // Conta c1 = new Corrente();
      // c1.Creditar(100);
      // c1.ExibirSaldo();

      // Calculadora calc = new Calculadora();
      // System.Console.WriteLine("Resultado da primeira soma " + calc.Somar(15, 15));
      // System.Console.WriteLine("Resultado da primeira soma " + calc.Somar(15, 15, 15));

      // Professor p1 = new Professor();
      // p1.Nome = "Bob";
      // p1.Idade = 20;
      // p1.Salario = 3500;
      // p1.Documento = "123456789";
      // p1.Apresentar();

      // Aluno p2 = new Aluno();
      // p2.Nome = "André";
      // p2.Idade = 20;
      // p2.Nota = 10;
      // p2.Documento = "123456789";
      // p2.Apresentar();

      // //Valores válido
      // Retangulo r = new Retangulo();
      // r.DefinirMedidas(10, 20);
      // System.Console.WriteLine($"Área: {r.ObterArea()}");
      // //Valores inválido
      // Retangulo r2 = new Retangulo();
      // r2.DefinirMedidas(-10, -20);
      // System.Console.WriteLine($"Área: {r2.ObterArea()}");

      //   Pessoa p1 = new Pessoa();
      //   p1.Nome = "Bob";
      //   p1.Idade = 20;
      //   p1.Apresentar();
    }
  }
}
