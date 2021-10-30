using System;
using System.Collections.Generic;
using CapaEntidad;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {
        public List<TipoMedicamentoCLS> ListarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
            lista.Add(new TipoMedicamentoCLS
            {
                id = 1,
                nombre = "Analgesico",
                descripcion = "Des 01"
            });
            lista.Add(new TipoMedicamentoCLS
            {
                id = 2,
                nombre = "Antialergico",
                descripcion = "Des 02"
            });
            return lista;
        }

    }
}
