using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExFinal.Config;
using ExFinal.Modelos;

namespace ExFinal.Controllers
{
    public class Partido_Controllers
    {
        
        public readonly conexion cn = new conexion();
        public int ID { get;set; }
        public int ID_Equipo1 { get;set; }
        public int ID_Equipo2 { get;set; }
        public DateTime Fecha { get;set; }
        public string Resultado { get;set; }

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
        
    public string AgregarPartido(Partido_Models partido)
        {
            using (var conexion = cn.obtenerConexion())
            {
                MessageBox.Show("@ID_Equipo2 - " + partido.id_Equipo2);
                MessageBox.Show("@ID_Equipo1 - " + partido.id_Equipo1);
                
                string cadena = "INSERT INTO Partido (ID_Equipo1, ID_Equipo2, Fecha, Resultado) VALUES (@ID_Equipo1, @ID_Equipo2, @Fecha, @Resultado)";
                using (var comando = new SqlCommand(cadena, conexion))
                {

                    comando.Parameters.AddWithValue("@ID_Equipo1", partido.id_Equipo1);
                    comando.Parameters.AddWithValue("@ID_Equipo2", partido.id_Equipo2);
                    comando.Parameters.AddWithValue("@Fecha", partido.Fecha);
                    comando.Parameters.AddWithValue("@Resultado", partido.Resultado ?? (object)DBNull.Value);
                    conexion.Open();

                    if (comando.ExecuteNonQuery() != 0)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error";
                    }
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
