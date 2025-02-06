using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExFinal.Config;

namespace ExFinal.Controllers
{
    public class Partido_Controllers
    {
        public readonly Conexion cn = new Conexion();

        public int ID { get; private set; }
        public int ID_Equipo1 { get; private set; }
        public int ID_Equipo2 { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Resultado { get; private set; }

        public List<Partido_Controllers> ObtenerPartidos()
        {
            var listaPartidos = new List<Partido_Controllers>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM Partido";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var partido = new Partido_Controllers
                            {
                                ID = (int)lector["ID"],
                                ID_Equipo1 = (int)lector["ID_Equipo1"],
                                ID_Equipo2 = (int)lector["ID_Equipo2"],
                                Fecha = (DateTime)lector["Fecha"],
                                Resultado = lector["Resultado"] as string
                            };
                            listaPartidos.Add(partido);
                        }
                    }
                }
            }
            return listaPartidos;
        }
        
    public void AgregarPartido(Partido_Controllers partido)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "INSERT INTO Partido (ID_Equipo1, ID_Equipo2, Fecha, Resultado) VALUES (@ID_Equipo1, @ID_Equipo2, @Fecha, @Resultado)";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@ID_Equipo1", partido.ID_Equipo1);
                    comando.Parameters.AddWithValue("@ID_Equipo2", partido.ID_Equipo2);
                    comando.Parameters.AddWithValue("@Fecha", partido.Fecha);
                    comando.Parameters.AddWithValue("@Resultado", partido.Resultado ?? (object)DBNull.Value);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarPartido(Partido_Controllers partido)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "UPDATE Partido SET ID_Equipo1 = @ID_Equipo1, ID_Equipo2 = @ID_Equipo2, Fecha = @Fecha, Resultado = @Resultado WHERE ID = @ID";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@ID", partido.ID);
                    comando.Parameters.AddWithValue("@ID_Equipo1", partido.ID_Equipo1);
                    comando.Parameters.AddWithValue("@ID_Equipo2", partido.ID_Equipo2);
                    comando.Parameters.AddWithValue("@Fecha", partido.Fecha);
                    comando.Parameters.AddWithValue("@Resultado", partido.Resultado ?? (object)DBNull.Value);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPartido(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "DELETE FROM Partido WHERE ID = @ID";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@ID", id);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
