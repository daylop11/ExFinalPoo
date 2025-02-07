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
    public class Jugador_Controllers
    {
        public object cn;

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
                            }
                                listaJugadores.Add(jugador);
                            }
                        }
                    }
                }
                return listaJugadores;
            }
        }

    }