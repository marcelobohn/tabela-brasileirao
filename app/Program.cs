using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela Brasileirão");
            
            ConsoleKeyInfo a;
            Campeonato campeonato = new Campeonato();
            do {
                Console.Write("1 => nova equipe | 2 => resultado ");
                Console.WriteLine("Digite sua opção: ");
                a = Console.ReadKey();            
                if (a.Key == ConsoleKey.D1) {
                    System.Console.WriteLine("# Adicionando uma nova equipe");
                    System.Console.WriteLine("Digite o nome da equipe: "); 
                    string nome = Console.ReadLine();
                    System.Console.WriteLine("Digite a pontuacao: "); 
                    string pontuacao = Console.ReadLine();
                    campeonato.equipes.Add(new Equipe(nome, Int32.Parse(pontuacao)));
                }
            } while (a.Key != ConsoleKey.D2);

            System.Console.WriteLine("Listando o resultado");
            campeonato.ordenaPontuacao();
            campeonato.resultado();

            System.Console.WriteLine(campeonato.equipes.Count);
            
        }
    }
}
