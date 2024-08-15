public class pais
{
    string Nombre {get;set;}
    string Bandera {get;set;}
    DateTime FechaFundacion {get;set;}

    public pais (){}

    public pais(string nombre, string bandera, DateTime fechafundacion)
    {
        Nombre = nombre;
        Bandera = bandera;
        FechaFundacion = fechafundacion;
    }
    
}