using System;

namespace CalculadoraApp
{
    public class Calculadora
    {
        public static double Adicionar(double a, double b) => a + b;
        public static double Subtrair(double a, double b) => a - b;
        public  double Multiplicar(double a, double b) => a * b;

        public static double? Dividir(double a, double b)
        {
            if (b == 0)
            {
                return null;
            }
            return a / b;
        }
        public  double LerNumero(string mensagem)
        {   
            double numero;
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), out numero))
                    return numero;
                Console.WriteLine("Entrada inválida. Digite um número válido.");
            }
        }

        public  int LerOperacao()
        {
            int operacao;
            while (true)
            {
                Console.Write("Digite o número da operação desejada (1/2/3/4): ");
                if (int.TryParse(Console.ReadLine(), out operacao) && operacao >= 1 && operacao <= 4)
                    return operacao;
                Console.WriteLine("Operação inválida. Escolha um número entre 1 e 4.");
            }
        }
    }

}