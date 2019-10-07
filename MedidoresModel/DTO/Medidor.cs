using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Medidor
    {
        private int idMedidor;
        private string tipo;

        public Medidor()
        {
        }

        public Medidor(int idMedidor, string tipo)
        {
            this.IdMedidor = idMedidor;
            this.Tipo = tipo;
        }

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

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
