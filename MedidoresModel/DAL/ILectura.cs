using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILectura
    {
        List<Lectura> Obtener();
        void Eliminar(int id);
        void Agregar(Lectura lectura);

        List<Lectura> filtrar(int id);
    }
}
