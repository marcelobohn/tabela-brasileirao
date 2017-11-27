using System.Collections.Generic;

namespace app
{
    public class Campeonato
    {
        public List<Equipe> equipes;
        const int quantidadeRebaixados = 2;

        public Campeonato(){
            this.equipes = new List<Equipe>();
        }

        public void resultado() {
            string detalhe = "";
            for(int i = 0; i < this.equipes.Count; i++) {
                detalhe = "";
                if (i == 0)
                    detalhe = " - Campeão";
                if (i >= this.equipes.Count - quantidadeRebaixados)
                    detalhe = " - Rebaixado";
                System.Console.WriteLine($"Equipe: {this.equipes[i].nome} - Pontuação: {this.equipes[i].pontuacao} {detalhe}");
            };        
        }

        public void ordenaPontuacao() {
            this.equipes.Sort((x, y) => y.pontuacao.CompareTo(x.pontuacao));
        }

    }
}
