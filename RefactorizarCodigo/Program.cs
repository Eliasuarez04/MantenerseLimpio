//Codigo Sucio

public class Pedido
{
    public double CalcularTotal(double precio, int cantidad, double impuesto)
    {
        return (precio * cantidad) + ((precio * cantidad) * impuesto);
    }
}

//Codigo Limpio

public class Pedido
{
    public double CalcularTotal(double precio, int cantidad, double impuesto)
    {
        double subtotal = precio * cantidad;
        return subtotal + (subtotal * impuesto);
    }
}

