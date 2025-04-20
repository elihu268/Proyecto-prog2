using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;
using Npgsql;
using System.Data;

namespace Sistema_Ventas.Data
{
    public class ClientesDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.VlienteDataAccess");
        /// 
        private readonly PostgreSQLDataAccess _dbAccess;

        private readonly PersonasDataAccess _personasData;



        public List<Cliente> ObtenerClientes(bool Activos)
        {
            //solo acitvos ==true; por defecto si no se pone el parmetro se pone true
            //tipo fecha=alta,baja,nacimiento
            //rango de fechas que interactua con la consultas, pueden estar nulas
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string query = @"
                    SELECT c.id_cliente,c.tipo,c.rfc,c.fecha _registro
                            CASE
                                WHEN c.estatus=0 THEN 'Baja'
                                WHEN c.estatus=1 THEN 'Activo'
                                    ELSE
                                        'Desconocido'
                            END AS descestatus_estudiante,
                                c.id_persona,p.nombre_completo,p.correo,p.telefono,p.fecha_nacimiento,p.estatus as estatus_persona
                    FROM pv.cliente c
                    INNER JOIN personas p ON e.id_persona=p.id_persona
                    WHERE 1=1";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();
                if (Activos)
                {
                    query += " AND e.estatus = 1";
                }
                query += " ORDER BY e.id";
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());
                
                foreach (DataRow row in resultado.Rows)
                {
                    //es el reglon de una tabla el resultado: por cada row recorrer, forecah de reglones de datatable
                    Persona persona = new Persona(//crear una persona, de acuerdo al constructor todos sus datos
                    Convert.ToInt32(row["id_persona"]),
                        row["nombre_completo"].ToString() ?? "",
                        row["correo"].ToString() ?? "",
                        row["telefono"].ToString() ?? "",
                        row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                         Convert.ToBoolean(row["estatus_persona"])
                        );

                    //crear el objeto cliente
                    Cliente cliente = new Cliente(
                  Convert.ToInt32(row["id_cliente"]),
                  Convert.ToInt32(row["id_persona"]),
                  Convert.ToInt32(row["tipo"]),
                  Convert.ToDateTime(row["fecha_registro"]),
                      row["rfc"].ToString() ?? "",
                      persona
                       );
                    clientes.Add(cliente);
                }
                _logger.Debug($"Se obtuvieron{clientes.Count} resgistros de clientes");
                return clientes;
            }
            catch (Exception ex)
            {
                //logear error
                _logger.Error(ex, "Error al obtener informacion de los clientes de la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();//asegura cierre de la conexion
            }
        }
    }
}
