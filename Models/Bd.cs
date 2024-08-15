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

}
