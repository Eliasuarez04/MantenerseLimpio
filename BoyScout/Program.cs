//Código Sucio

public class Cliente
{
    public string Nombre;
    public string Email;

    public Cliente(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }
}



//Codigo Limpio

public class Cliente
{
    public string Nombre { get; }
    public string Email { get; }

    public Cliente(string nombre, string email)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
        if (!email.Contains("@")) throw new ArgumentException("Email inválido.");

        Nombre = nombre;
        Email = email;
    }
}
