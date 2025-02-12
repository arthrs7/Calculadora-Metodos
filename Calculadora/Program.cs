using System;
using CalculadoraApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo à Calculadora!");
        Calculadora calculadora = new Calculadora();

        double num1 = calculadora.LerNumero("Digite o primeiro número: ");
        double num2 = calculadora.LerNumero("Digite o segundo número: ");

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1. Adição (+)");
        Console.WriteLine("2. Subtração (-)");
        Console.WriteLine("3. Multiplicação (*)");
        Console.WriteLine("4. Divisão (/)");

        int operacao = calculadora.LerOperacao();

        switch (operacao)
        {
            case 1:
                Console.WriteLine($"Resultado: {num1} + {num2} = {Calculadora.Adicionar(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {num1} - {num2} = {Calculadora.Subtrair(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {num1} * {num2} = {calculadora.Multiplicar(num1, num2)}");
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} = {Calculadora.Dividir(num1, num2)}");
                }
                break;
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

}

