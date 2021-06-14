using System;
using DIO.Bank.Classes;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0,0, "Fabricio Procaci");

            System.Console.WriteLine(minhaConta.ToString());

        }
    }
}
