public class deporte
{
    int IdDeporte {get;set;}
    string Nombre {get;set;}
    string Foto {get;set;}


    public deporte () {}

    public deporte (int iddeporte, string nombre, string foto)
    {
        IdDeporte = iddeporte;
        Nombre = nombre;
        Foto = foto;
    }

}