public class deportista
{
    string Apellido {get;set;}
    string Nombre {get;set;}
    DateTime FechaNacimiento {get;set;}
    string Foto {get;set;}


    public deportista () {}
    public deportista (string apellido, string nombre, DateTime fechanacimiento, string foto)
    {
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento;
        Foto = foto;
    }

}



