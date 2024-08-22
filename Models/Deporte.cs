public class deporte
{
    public int IdDeporte {get;set;}
    public string Nombre {get;set;}
    public string Foto {get;set;}


    public deporte () {}

    public deporte (int iddeporte, string nombre, string foto)
    {
        IdDeporte = iddeporte;
        Nombre = nombre;
        Foto = foto;
    }

}