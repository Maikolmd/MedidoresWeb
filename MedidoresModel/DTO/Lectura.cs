using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Lectura
    {
        private int idMedidor;
        private decimal valorConsumo;
        private DateTime fecha;

        public int IdMedidor
        {
            get
            {
                return idMedidor;
            }

            set
            {
                idMedidor = value;
            }
        }

        public decimal ValorConsumo
        {
            get
            {
                return valorConsumo;
            }

            set
            {
                valorConsumo = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Lectura(int idMedidor, decimal valorConsumo, DateTime fecha)
        {
            this.IdMedidor = idMedidor;
            this.ValorConsumo = valorConsumo;
            this.Fecha = fecha;
        }

        public Lectura()
        {
        }
    }
}
