using System.Data.SqlClient;
using Dapper;

namespace tp6_jjoo;
static public class Bd
{
private static string _connectionString = @"Server=localhost; DataBase=JJOO; Trusted_Connection=True;";


public static void AgregarDeportista(deportista dep)
{   
    using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "INSERT INTO DEPORTISTAS (NOMBRE, APELLIDO) VALUES (TIAGO, GHELMAN)";
        Bd.Execute(sql);
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
public static pais VerInfoPais(int IdPais)
{
         pais _VerInfoPaises = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Deportes where IdPais = @id";
        _VerInfoPaises = Bd.QueryFirstOrDefault<pais>(sql, new{id=IdPais});
    }
    return _VerInfoPaises;
}
public static deportista VerInfoDeportista(int idDeportista)
{
    deportista _VerInfoDeportistas = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Deportes where IdDeportista = @id";
        _VerInfoDeportistas = Bd.QueryFirstOrDefault<deportista>(sql, new{id=idDeportista});
    }
    return _VerInfoDeportistas;
}

public static List <pais> ListarPaises()
{
    List <pais> _ListarPaises = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM pais where ";
        _ListarPaises = Bd.Query<pais>(sql).ToList();
    }
    return _ListarPaises;
}

public static List <deportista> ListarDeportista(int IdDeporte)
{
    List <deportista> _ListarDeportistas = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM deportistas where IdDeporte=IdDeportista";
        _ListarDeportistas = Bd.Query<deportista>(sql).ToList();
    }
    return _ListarDeportistas;
}
public static List <deportista> ListarDeportistas(int IdPais)
{
    List <deportista> _ListarDeportistas = null;
        using(SqlConnection Bd = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM deportista where IdPais=IdDeportista";
        _ListarDeportistas = Bd.Query<deportista>(sql).ToList();
    }
    return _ListarDeportistas;
}







}
