using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExFinal.Config;
using ExFinal.Modelos;
using ExFinal.Controllers;


namespace ExFinal.Controllers
{
    public class Jugador_Controllers
    {
        public conexion cn = new conexion();

        public List<Jugador_Models> ObtenerJugadores()
        {
            var listaJugadores = new List<Jugador_Models>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM Jugador";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var jugador = new Jugador_Models
                            {
                                ID = (int)lector["ID"],
                                Nombre = (string)lector["Nombre"],
                                Posicion = (string)lector["Posicion"],
                                ID_Equipo = (int)lector["ID_Equipo"]
                            };
                            listaJugadores.Add(jugador);
                        }
                    }
                }
            }
            return listaJugadores;
        }

        public string insertar(Jugador_Models nuevoJugador)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "INSERT INTO Jugador (Nombre, Posicion, ID_Equipo) VALUES (@Nombre, @Posicion, @ID_Equipo)";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nuevoJugador.Nombre);
                    comando.Parameters.AddWithValue("@Posicion", nuevoJugador.Posicion);
                    comando.Parameters.AddWithValue("@ID_Equipo", nuevoJugador.ID_Equipo);

                    conexion.Open();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        return "Jugador insertado correctamente";
                    }
                    else
                    {
                        return "Error al insertar jugador";
                    }


                }
            }
        }

    }
}