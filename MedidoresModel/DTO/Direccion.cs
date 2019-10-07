using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
   public class Direccion
    {
        private int id;
        private string descripcion;
        private string numero;
        private int numeroCasa;
        private int codigoCliente;
        private int codigoRegion;
        private int idMedidor;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public int NumeroCasa
        {
            get
            {
                return numeroCasa;
            }

            set
            {
                numeroCasa = value;
            }
        }

        public int CodigoCliente
        {
            get
            {
                return codigoCliente;
            }

            set
            {
                codigoCliente = value;
            }
        }

        public int CodigoRegion
        {
            get
            {
                return codigoRegion;
            }

            set
            {
                codigoRegion = value;
            }
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

        public Direccion(int id, string descripcion, string numero, int numeroCasa, int codigoCliente, int codigoRegion, int idMedidor)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Numero = numero;
            this.NumeroCasa = numeroCasa;
            this.CodigoCliente = codigoCliente;
            this.CodigoRegion = codigoRegion;
            this.IdMedidor = idMedidor;
        }
    }
}
