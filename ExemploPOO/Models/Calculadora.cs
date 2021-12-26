using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
  public class Calculadora : ICalculadora
  {
    public int Somar(int valor1, int valor2)
    {
      return valor1 + valor2;
    }

    public int Somar(int valor1, int valor2, int valor3)
    {
      return valor1 + valor2 + valor3;
    }

    public int Subtrair(int num1, int num2)
    {
      return num1 - num2;
    }
  }
}