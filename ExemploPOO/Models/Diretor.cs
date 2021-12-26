using System;

namespace ExemploPOO.Models
{
  public class Diretor : Professor
  {
    public override void Apresentar()
    {
      Console.WriteLine($"Olá, sou diretor e meu nome é {Nome}!");
    }
  }
}