public class pais
{
    int IdPais {get;set;}
    string Nombre {get;set;}
    string Bandera {get;set;}
    DateTime FechaFundacion {get;set;}

    public pais (){}

    public pais(int idpais, string nombre, string bandera, DateTime fechafundacion)
    {   
        IdPais = idpais;
        Nombre = nombre;
        Bandera = bandera;
        FechaFundacion = fechafundacion;
    }
    
}