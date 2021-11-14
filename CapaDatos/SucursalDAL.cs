using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class SucursalDAL : CadenaDAL
    {
        public List<SucursalCLS> ListarSucursal()
        {
            List<SucursalCLS> lista = null;

            using (SqlConnection db = new SqlConnection(cadena))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("select nombre, iidtipomedicamento,  descripcion from TipoMedicamento where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (drd != null)
                        {
                            SucursalCLS oSucursalCLS;
                            lista = new List<SucursalCLS>();

                            int postId = drd.GetOrdinal("iidsucursal");
                            int postNombre = drd.GetOrdinal("nombre");
                            int postDireccion = drd.GetOrdinal("direccion");

                            while (drd.Read())
                            {
                                oSucursalCLS = new SucursalCLS();
                                oSucursalCLS.iidsucursal = drd.IsDBNull(postId) ? 0 : drd.GetInt32(postId);
                                oSucursalCLS.nombre = drd.IsDBNull(postNombre) ? "" : drd.GetString(postNombre);
                                oSucursalCLS.direccion = drd.IsDBNull(postDireccion) ? "" : drd.GetString(postDireccion);
                                lista.Add(oSucursalCLS);
                            }
                            db.Close();
                        }
                    }
                }

                catch (Exception ex)
                {
                    db.Close();
                    lista = null;
                }

            }


            return lista;
        }
    }
}
