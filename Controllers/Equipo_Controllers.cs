using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExFinal.Config;
using ExFinal.Modelos;

namespace ExFinal.Controllers
{
    public class Equipo_Controllers
    {
        public readonly conexion cn = new conexion();

        public List<Equipo_Models> ObtenerEquipos()
        {
            var listaEquipos = new List<Equipo_Models>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM Equipo";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var equipo = new Equipo_Models
                            {
                                ID = (int)lector["ID"],
                                Nombre = (string)lector["Nombre"],
                                Ciudad = (string)lector["Ciudad"]
                            };
                            listaEquipos.Add(equipo);
                        }
                    }
                }
            }
            return listaEquipos;
        }
        public void AgregarEquipo(Equipo_Models equipo)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "INSERT INTO Equipo (Nombre, Ciudad) VALUES (@Nombre, @Ciudad)";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    comando.Parameters.AddWithValue("@Ciudad", equipo.Ciudad);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }



        public void ActualizarEquipo(Equipo_Models equipo)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "UPDATE Equipo SET Nombre = @Nombre, Ciudad = @Ciudad WHERE ID = @ID";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@ID", equipo.ID);
                    comando.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    comando.Parameters.AddWithValue("@Ciudad", equipo.Ciudad);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarEquipo(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "DELETE FROM Equipo WHERE ID = @ID";
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
