using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
   public class Trabajador
    {
        private int codigo;
        private string rut;
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string correo;
        private string clave;

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

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public Trabajador(int codigo, string rut, string nombre, string apellidoMaterno, string apellidoPaterno, string correo, string clave)
        {
            this.Codigo = codigo;
            this.Rut = rut;
            this.Nombre = nombre;
            this.ApellidoMaterno = apellidoMaterno;
            this.ApellidoPaterno = apellidoPaterno;
            this.Correo = correo;
            this.Clave = clave;
        }
    }
}
