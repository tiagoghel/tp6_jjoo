public class Deportistas
{
    public int IdDeportista {get;set;} 
    public string Apellido {get;set;}
    public string Nombre {get;set;}
    public DateTime FechaDeNacimiento {get;set;}
    public string Foto {get;set;}
    public int IDpais {get;set;}
    public int IDdeporte {get;set;}


    public Deportistas () {}
    public Deportistas (int iddeportista, string apellido, string nombre, DateTime fechanacimiento, string foto, int idpais, int iddeporte)
    {
        IdDeportista = iddeportista;
        Apellido = apellido;
        Nombre = nombre;
        FechaDeNacimiento = fechanacimiento;
        Foto = foto;
        IDpais = idpais;
        IDdeporte = iddeporte;
    }

}



