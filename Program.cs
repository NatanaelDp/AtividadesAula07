using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
        
        
        
        void atividade04()
        {
            double nota1, nota2, nota3;




            Console.WriteLine("Bem-vindo ao sistema educacional de São Paulo");
            Console.WriteLine("Agora digite suas 3 notas");
            Console.WriteLine("Digite a primeira nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            nota3 = double.Parse(Console.ReadLine());
            double maiorNota = nota1;
            if (nota2 > maiorNota)
            {
                maiorNota = nota2;

            }
            if (nota3 > maiorNota)
            {
                maiorNota = nota3;
            }
            Console.WriteLine($"A maior nota é de {maiorNota}");




            Console.ReadKey();
        }
        void atividade03()
        {
            double nota1, nota2;



            Console.WriteLine("Bem-vindo ao sistema educacional de São Paulo\n");
            Console.WriteLine("Escreva suas duas últimas notas:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            Console.WriteLine($"Sua média atual é de {media}");
            if (media > 6)
            {
                Console.WriteLine("Média superior á média mínima (6,0)");

            }
            if (media == 6)
            {
                Console.WriteLine("Média igual à média mínima (6,0)");
            }
            if (media < 6)
            {
                Console.WriteLine("Média inferior a média mínima");
            }


            Console.ReadKey();
        }
        void atividade02()
        {
            string nome;
            double media;

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua média:");
            media = double.Parse(Console.ReadLine());
            Console.WriteLine($"Seu nome é {nome} e sua nota é {media}\n");
            Console.WriteLine("Vamos verificar se você foi aprovado");
            if (media >= 6.0)
            {
                Console.WriteLine($"O aluno {nome} está aprovado");
            }
            else
            {
                Console.WriteLine($"Infelizmente o aluno {nome} reprovou");
            }

            Console.ReadKey();

        }
        void atividade01()
        {
            int numerico;
            Console.WriteLine("Escreva um número");
            numerico = int.Parse(Console.ReadLine());
            if (numerico > 100)
            {
                Console.WriteLine($"Seu numero somado a 150 dá {numerico + 150} ");
            }
            if (numerico < 100)
            {
                Console.WriteLine("Número inválido escreva um acima de 100");
                Main(null);
                return;
            }
            Console.ReadKey();
        }
    }
}
