//Código Sucio

public class Factura
{
    public double CalcularTotal(double precio, int cantidad, double descuento)
    {
        return precio * cantidad - (precio * cantidad * descuento);
    }
}


//Código Limpio

public class Factura
{
    public double CalcularTotal(double precio, int cantidad, double descuento)
    {
        if (precio < 0 || cantidad < 0 || descuento < 0 || descuento > 1)
            throw new ArgumentException("Valores inválidos en el cálculo.");

        double subtotal = precio * cantidad;
        return subtotal - (subtotal * descuento);
    }
}
