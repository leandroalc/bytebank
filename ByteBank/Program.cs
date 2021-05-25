using ByteBan;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a classe:
            ContaCorrente contaDaGabriela = new ContaCorrente();

            //Atribuindo valores:
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            //Exibindo valores:
            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            //Realizando incremento em um atributo:
            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
