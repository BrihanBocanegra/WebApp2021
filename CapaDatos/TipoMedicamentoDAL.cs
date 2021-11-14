using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {

        public List<TipoMedicamentoCLS> ListarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = null;

            IConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            var cadenaDato = root.GetConnectionString("db");

            using (SqlConnection db = new SqlConnection(cadenaDato))
            {
                try
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("select iidtipomedicamento, nombre, descripcion from TipoMedicamento where BHABILITADO = 1", db))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader();

                        if (drd != null)
                        {
                            TipoMedicamentoCLS oTipoMedicamentoCLS;
                            lista = new List<TipoMedicamentoCLS>();

                            while (drd.Read())
                            {
                                oTipoMedicamentoCLS = new TipoMedicamentoCLS();
                                oTipoMedicamentoCLS.iidtipomedicamento = drd.GetInt32(0);
                                oTipoMedicamentoCLS.nombre = drd.GetString(1);
                                oTipoMedicamentoCLS.descripcion = drd.GetString(2);
                                lista.Add(oTipoMedicamentoCLS);
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
