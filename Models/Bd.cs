using System.Data.SqlClient;
using Dapper;

namespace tp6_jjoo;
static public class Bd
{
private static string _connectionString = @"Server=localhost; DataBase=JJOO; Trusted_Connection=True;";


public static void AgregarDeportista(Deportistas dep)
{   
    using (SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "INSERT INTO DEPORTISTAS (Apellido, Nombre, FechaDeNacimiento, Foto, IDpais, IDdeporte) VALUES (@pApellido, @pNombre, @pFechaDeNacimiento, @pFoto, @pIDpais, @pIDdeporte)";
        Bd.Execute(sql, new
        {
            pApellido = dep.Apellido,
            pNombre = dep.Nombre,
            pFechaDeNacimiento = dep.FechaDeNacimiento,
            pFoto = dep.Foto,
            pIDpais = dep.IDpais,
            pIDdeporte = dep.IDdeporte
        });
    }
}
public static void EliminarDeportista(int idDeportista)
{   
    using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "DELETE FROM Deportista WHERE (NOMBRE, APELLIDO) VALUES (TIAGO, GHELMAN)";
        Bd.Execute(sql);
    }
}
public static deporte VerInfoDeporte(int IdDeporte)
{
        deporte _VerInfoDeportes = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Deportes where IdDeporte = @id";
        _VerInfoDeportes = Bd.QueryFirstOrDefault<deporte>(sql, new{id=IdDeporte});
    }
    return _VerInfoDeportes;
}
public static Pais VerInfoPais(int IdPais)
{
         Pais _VerInfoPaises = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Pais where IDpais = @id";
        _VerInfoPaises = Bd.QueryFirstOrDefault<Pais>(sql, new{id=IdPais});
    }
    return _VerInfoPaises;
}
public static Deportistas VerInfoDeportista(int idDeportista)
{
    Deportistas _VerInfoDeportistas = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Deportistas where IdDeportista = @id";
        _VerInfoDeportistas = Bd.QueryFirstOrDefault<Deportistas>(sql, new{id=idDeportista});
    }
    return _VerInfoDeportistas;
}

public static List <Pais> ListarPaises()
{
    List <Pais> _ListarPaises = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM pais ";
        _ListarPaises = Bd.Query<Pais>(sql).ToList();
    }
    return _ListarPaises;
}

public static List <Deportistas> ListarDeportistasXDeporte(int IdDeporte)
{
    List <Deportistas> _ListarDeportistas = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM deportistas where IdDeporte=@pIdDeporte";
        _ListarDeportistas = Bd.Query<Deportistas>(sql, new {pIdDeporte = IdDeporte}).ToList();
    }
    return _ListarDeportistas;
}
public static List <Deportistas> ListarDeportistasXPais(int IdPais)
{
    List <Deportistas> _ListarDeportistas = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM deportistas where IdPais=@pIdPais";
        _ListarDeportistas = Bd.Query<Deportistas>(sql, new {pIdPais = IdPais}).ToList();
    }
    return _ListarDeportistas;
}

public static List <deporte> ListarDeportes()
{
    List <deporte> _ListarDeportes = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM deportes";
        _ListarDeportes = Bd.Query<deporte>(sql).ToList();
    }
    return _ListarDeportes;
}






}
