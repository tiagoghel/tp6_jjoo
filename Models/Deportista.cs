public class deportista
{
    int IdDeportista {get;set;}
    string Apellido {get;set;}
    string Nombre {get;set;}
    DateTime FechaNacimiento {get;set;}
    string Foto {get;set;}
    int IdPais {get;set;}
    int IdDeporte {get;set;}


    public deportista () {}
    public deportista (int iddeportista, string apellido, string nombre, DateTime fechanacimiento, string foto, int idpais, int iddeporte)
    {
        IdDeportista = iddeportista;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento;
        Foto = foto;
        IdPais = idpais;
        IdDeporte = iddeporte;
    }

}



