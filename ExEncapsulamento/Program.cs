namespace ExEncapsulamento
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome");
            Cliente a = new Cliente(Console.ReadLine());

            Console.WriteLine($"CONTA ABERTA, O NÚMERO DA SUA CONTA É: {a.NumeroConta}");
            Thread.Sleep(2000);
            Console.Clear();

            bool funciona = true;
            int opcao = 0;
            while (funciona)
            {
                Console.WriteLine("O QUE VOCÊ DESEJA FAZER?");
                Console.WriteLine("1- Deposito");
                Console.WriteLine("2- Saque");
                Console.WriteLine("3- Mostrar dados");
                Console.WriteLine("4- Mudar o nome");
                Console.WriteLine("5- Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do depósito: ");
                        a.Deposito(double.Parse(Console.ReadLine()));
                        Console.WriteLine("DEPÓSITO FEITO COM SUCESSO!!!");
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do saque: ");
                        a.Saque(double.Parse(Console.ReadLine()));
                        Console.WriteLine("SAQUE FEITO COM SUCESSO!!!");
                        break;
                    case 3:
                        Console.WriteLine($"NOME: {a.Nome}");
                        Console.WriteLine($"NUMERO DA CONTA: {a.NumeroConta}");
                        Console.WriteLine($"SALDO: {a.Saldo}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Qual o novo nome?");
                        a.Nome = Console.ReadLine();
                        Console.WriteLine("NOME ALTERADO");
                        break;
                    default:
                        funciona = false;
                        break;
                }
            }
        }
    }
}