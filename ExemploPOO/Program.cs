using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      //Valores válido
      Retangulo r = new Retangulo();
      r.DefinirMedidas(10, 20);
      System.Console.WriteLine($"Área: {r.ObterArea()}");
      //Valores inválido
      Retangulo r2 = new Retangulo();
      r2.DefinirMedidas(-10, -20);
      System.Console.WriteLine($"Área: {r2.ObterArea()}");

      //   Pessoa p1 = new Pessoa();
      //   p1.Nome = "Bob";
      //   p1.Idade = 20;
      //   p1.Apresentar();
    }
  }
}
