using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEncapsulamento
{
    internal class Cliente
    {

        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Random numAleatorio = new Random();
            Nome = nome;
            NumeroConta = numAleatorio.Next();
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            //Taxa de saque de 10 reais
            Saldo = Saldo - 10 - valor;
        }

    }
}



