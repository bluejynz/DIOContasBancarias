using DIOAgenciaBancaria.Dominio;
using System;

namespace DIOAgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua Raul Sertã, 269", "28614090", "Nova Friburgo", "Rio de Janeiro");
                Cliente cliente = new Cliente("Daniela Falk", "06250284737", "271014532", endereco);
                ContaCorrente conta = new ContaCorrente(cliente, 100);

                string senha = "danI1223*";
                Console.WriteLine($"Conta {conta.Situacao}: {conta.NumeroConta}-{conta.DigitoVerificador}");

                conta.Abrir(senha);
                Console.WriteLine($"Conta {conta.Situacao}: {conta.NumeroConta}-{conta.DigitoVerificador}");

                conta.Sacar(10, senha);
                Console.WriteLine($"Saldo {conta.Saldo}");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
