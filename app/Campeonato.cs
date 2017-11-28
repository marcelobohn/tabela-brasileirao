using System.Collections.Generic;

namespace app
{
    public class Campeonato
    {
        public List<Equipe> equipes;
        public Equipe campea;
        public List<Equipe> rebaixadas;
        const int quantidadeRebaixados = 2;

        public Campeonato(){
            this.equipes = new List<Equipe>();
            this.rebaixadas = new List<Equipe>();
        }

        public void exibeResultado() {
            
            this.equipes.ForEach(delegate(Equipe e){
                System.Console.WriteLine(this.textoEquipe(e));
            });        
        }        
    
        public string textoEquipe(Equipe e) {
            string detalhe = "";
            if (this.rebaixadas.FindIndex(a => a.nome == e.nome) > -1)    
                detalhe = "Rebaixada";
            if (e.nome == this.campea.nome)
                detalhe = "Campeã";
            return $"Equipe: {e.nome} - Pontuação: {e.pontuacao} {detalhe}";
        }

        public void ordenaPontuacao() {
            this.equipes.Sort((x, y) => y.pontuacao.CompareTo(x.pontuacao));
        }

        public void analisaResultado() {            
            this.ordenaPontuacao();

            for(int i = 0; i < this.equipes.Count; i++) {
                if (i == 0)
                    this.campea = this.equipes[i];
                if (i >= (this.equipes.Count - quantidadeRebaixados))
                    this.rebaixadas.Add(this.equipes[i]);
            };   
        }

    }
}
