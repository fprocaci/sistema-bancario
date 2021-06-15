using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> ListContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        ListarContas();
    	                break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default :
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            System.Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadLine();
        
        }

        private static void Transferir()
        {
            System.Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTrasnferencia = double.Parse(Console.ReadLine());

            ListContas[indiceContaOrigem].Transferir(valorTrasnferencia, ListContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            System.Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser Depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            ListContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            System.Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            ListContas[indiceConta].Sacar(valorSaque);
        }

        private static void InserirConta()
        {
            System.Console.WriteLine("Inserir nova conta: ");

            System.Console.Write("Digite 1 para conta pessoa física ou 2 para jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            System.Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            System.Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            ListContas.Add(novaConta);
        }

        private static void ListarContas(){
            System.Console.WriteLine("Listar Contas: ");

            if(ListContas.Count == 0){
                System.Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            for(int i = 0; i < ListContas.Count; i++){
                Conta conta = ListContas[i];
                System.Console.Write($"# {i} - ");
                System.Console.WriteLine(conta);
            }
        }

        private static string ObterOpcaoUsuario(){
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Bank a seu dispor!");
            System.Console.WriteLine("Informe as opção desejada:");

            System.Console.WriteLine("1 - Listar contas");
            System.Console.WriteLine("2 - Inserir nova conta");
            System.Console.WriteLine("3 - Transferir");
            System.Console.WriteLine("4 - Sacar");
            System.Console.WriteLine("5 - Depositar");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
