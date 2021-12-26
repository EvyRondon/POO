using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      Computador comp = new Computador();
      System.Console.WriteLine(comp.ToString());

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
