//Código Sucio 

public class Usuario
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Contraseña { get; set; } // Esto no debería ser público

    public Usuario(string nombre, string correo, string contraseña)
    {
        Nombre = nombre;
        Correo = correo;
        Contraseña = contraseña;
    }
}


//Código Limpio
public class Usuario
{
    public string Nombre { get; }
    public string Correo { get; }
    private string Contraseña { get; }

    public Usuario(string nombre, string correo, string contraseña)
    {
        Nombre = nombre;
        Correo = correo;
        Contraseña = HashPassword(contraseña);
    }

    private string HashPassword(string contraseña)
    {
        // Simulación de hash para evitar almacenar la contraseña en texto plano
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(contraseña));
    }
}
