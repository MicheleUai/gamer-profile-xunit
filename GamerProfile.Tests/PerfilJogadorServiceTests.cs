using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    [Fact]
    public void DeveGerarTagUsuarioCorretamente()
    {
        var service = new PerfilJogadorService();

        string resultado = service.GerarTagUsuario("Nickname", "0000");

        Assert.Equal("Nickname#0000", resultado);
    }

    [Fact]
    public void DeveCalcularXPTotalCorretamente()
    {
        var service = new PerfilJogadorService();

        int resultado = service.CalcularXPTotal(200, 300);

        Assert.Equal(600, resultado);
    }

    [Fact]
    public void DeveRetornarTrueParaJogadorElegivel()
    {
        var service = new PerfilJogadorService();

        bool resultado = service.ElegivelParaRanked(15);

        Assert.True(resultado);
    }

    [Fact]
    public void DeveRetornarFalseParaJogadorNaoElegivel()
    {
        var service = new PerfilJogadorService();

        bool resultado = service.ElegivelParaRanked(14);

        Assert.False(resultado);
    }
}