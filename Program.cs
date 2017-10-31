using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Instituto Ivoti";
            // Console.WriteLine("Hello World!");
            Console.WriteLine(nome);

            /*double valor = 2.2;
            double quantidade = 6.234;
            double resultado = valor * quantidade;

            Boolean maiorQueDez = (resultado > 10);
            if (maiorQueDez) {
                // com posição
                System.Console.WriteLine("{0} é maior que dez", resultado);
            } else {
                // com interpolação
                System.Console.WriteLine($"{resultado} é menor que dez");
            }

            InverteString inversor = new InverteString();
            inversor.inverte("instituto");
            System.Console.WriteLine(inversor.exibeUltimaInversao());
            */

            Human h = new Human();
            if (h.validate()) {
                System.Console.WriteLine("Acertou!!");
            } else {
                System.Console.WriteLine("Errroou!!");
            }

        }
    }
}
