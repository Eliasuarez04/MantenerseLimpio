//Código Sucio
public class Calculadora
{
    public int Sumar(int a, int b)
    {
        int resultado = 0;
        resultado = a + b;
        return resultado;
    }
}

//Codigo limpio

public class Calculadora
{
    public int Sumar(int a, int b) => a + b;
}
