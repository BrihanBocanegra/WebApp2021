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
                descripcion = "Des 01",
                price = Convert.ToDecimal ("10.22")
            });
            lista.Add(new TipoMedicamentoCLS
            {
                id = 2,
                nombre = "Antialergico",
                descripcion = "Des 02",
                price = Convert.ToDecimal("0.50")
            });
            lista.Add(new TipoMedicamentoCLS
            {
                id = 3,
                nombre = "Paracetamol",
                descripcion = "Des 03",
                price = Convert.ToDecimal("11.11")
            });
            lista.Add(new TipoMedicamentoCLS
            {
                id = 4,
                nombre = "Ácido Fólico",
                descripcion = "Des 03",
                price = Convert.ToDecimal("1.22")
            });
            return lista;
        }

    }
}
