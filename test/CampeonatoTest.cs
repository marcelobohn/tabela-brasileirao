using System;
using Xunit;
using app;

namespace test
{
    public class CampeonatoTest
    {
        [Fact]
        public void TestCriaNovo()
        {   
            Campeonato brasil2017 = new Campeonato();
            brasil2017.equipes.Add(new Equipe("Gremio", 10));
            Assert.Equal("Gremio", brasil2017.equipes[0].nome);
            Assert.Equal(10, brasil2017.equipes[0].pontuacao);
        }
        [Fact]
        public void TestCriaLista()
        {   
            Campeonato brasil2017 = new Campeonato();
            brasil2017.equipes.Add(new Equipe("Gremio", 10));
            brasil2017.equipes.Add(new Equipe("Internacional", 10));
            brasil2017.equipes.Add(new Equipe("Chapecoense", 10));
            brasil2017.equipes.Add(new Equipe("Santos", 10));

            Assert.Equal(4, brasil2017.equipes.Count);
            Assert.Equal("Santos", brasil2017.equipes[3].nome);
        }        
        [Fact]
        public void TestCriaListaOrdena()
        {   
            Campeonato brasil2017 = new Campeonato();
            brasil2017.equipes.Add(new Equipe("Gremio", 20));
            brasil2017.equipes.Add(new Equipe("Internacional", 10));
            brasil2017.equipes.Add(new Equipe("Chapecoense", 40));
            brasil2017.equipes.Add(new Equipe("Santos", 30));
            brasil2017.ordenaPontuacao();

            Assert.Equal("Chapecoense", brasil2017.equipes[0].nome);
            Assert.Equal("Internacional", brasil2017.equipes[3].nome);
        }           
    }
}
