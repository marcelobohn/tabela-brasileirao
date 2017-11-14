using System;
using Xunit;
using app;

namespace test
{
    public class EquipeTest
    {
        [Fact]
        public void TestCriaNovo()
        {   
            Equipe equipe = new Equipe("Gremio", 10);
            Assert.Equal("Gremio", equipe.nome);
            Assert.Equal(10, equipe.pontuacao);
        }
    }
}
