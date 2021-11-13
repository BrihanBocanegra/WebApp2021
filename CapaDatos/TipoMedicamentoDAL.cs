using System;
using System.Collections.Generic;
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

            }


            return lista;
        }

    }
}
