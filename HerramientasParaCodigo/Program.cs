//Código Sucio

public class Matematica
{
    public int Sumar(int a, int b) => a + b;
}


//Código Limpio

using Xunit;

public class MatematicaTests
{
    [Fact]
    public void Sumar_DosNumeros_RetornaSumaCorrecta()
    {
        var matematica = new Matematica();
        int resultado = matematica.Sumar(2, 3);
        Assert.Equal(5, resultado);
    }
}
