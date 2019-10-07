using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
   public  class Cliente
    {

        private int codigo;
        private string rut;
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string correo;

        public Cliente(int codigo, string rut, string nombre, string apellidoMaterno, string apellidoPaterno, string correo)
        {
            this.codigo = codigo;
            this.rut = rut;
            this.nombre = nombre;
            this.apellidoMaterno = apellidoMaterno;
            this.apellidoPaterno = apellidoPaterno;
            this.correo = correo;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }

            set
            {
                apellidoMaterno = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }

            set
            {
                apellidoPaterno = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }
    }
}
