using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
   public interface IMedidor
    {

        List<Medidor> Obtener();
        void Eliminar(int id);
        void Agregar(Medidor medidor);

        List<Medidor> filtrar(string tipo);



    }
}
