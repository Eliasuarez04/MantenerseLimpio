//Codigo Sucio
public class Persona
{
    private string nombre; // Variable que almacena el nombre de la persona

    // Constructor de la clase Persona
    public Persona(string nombre)
    {
        this.nombre = nombre; // Asigna el valor al atributo nombre
    }

    // Método que obtiene el nombre de la persona
    public string ObtenerNombre()
    {
        return nombre; // Retorna el nombre
    }
}


//Codigo Limpio
public class Persona
{
    private readonly string nombre;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public string ObtenerNombre() => nombre;
}

