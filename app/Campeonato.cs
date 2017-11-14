using System.Collections.Generic;

namespace app
{
    public class Campeonato
    {
        public List<Equipe> equipes;

        public Campeonato(){
            this.equipes = new List<Equipe>();
        }

        public void resultado() {
            this.equipes.ForEach(delegate(Equipe e){
                System.Console.WriteLine($"Equipe: {e.nome} - Pontuação: {e.pontuacao}");
            });        
        }
    }
}
