using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome");
            String Nome = Console.ReadLine();
            Console.WriteLine("Bem vindo senhor(a) " + Nome);
            Console.WriteLine();
            Console.WriteLine("O que gostaria de fazer?");
            Console.WriteLine(" 1- Abrir Reclamacao/  2 - Sugestao  / 3 Falar com um atendente");
            String Escolha = (Console.ReadLine());

            if (Escolha == "1")
            {
                Console.WriteLine("Escreva aqui o motivo da sua reclamação");
                String reclamar = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Obrigado pela sua cooperação Senhor(a) " + Nome + ", iremos te dar um retorno o mais rápido possível");
                Console.ReadKey();
            }
            if (Escolha == "2")
            {
                Console.WriteLine("Sua participação é muito importante para nós Senhor(a) " + Nome + ", conte-nos o que podemos melhorar");
                String sugestaocliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Obrigado por sua colaboração");
                Console.ReadKey();
            }
            if (Escolha == "3") 
            {
                Console.WriteLine("Por favor, ligue para o número 0800 -xxxxx-xxxx");
                Console.WriteLine();
                Console.WriteLine("Obrigado por sua colaboração");
                Console.ReadKey();
            }
           
        }
    }
}  

    
