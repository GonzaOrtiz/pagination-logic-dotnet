namespace prueba;

public class Usuario
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
}
public class Users
{
    public List<Usuario> usuario { get; set; }
}