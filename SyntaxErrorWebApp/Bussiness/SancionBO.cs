/*
using Model;
using Model.utils;
using Persistance.DAO;
using Persistance.DAOImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SancionBO
    {
        private SancionDAO sancionDAO;

        public SancionBO()
        {
            this.sancionDAO = new SancionDAOImpl();
        }

        public int Insertar(TipoSancion? tipo, DateTime? fecha, double? monto, DateTime? duracion, string descripcion, int? idPrestamo)
        {
            SancionDTO sancion = new SancionDTO
            {
                Tipo = tipo,
                Fecha = fecha,
                Monto = monto,
                Duracion = duracion,
                Descripcion = descripcion,
                Prestamo = new PrestamoDTO { IdPrestamo = idPrestamo }
            };

            return this.sancionDAO.Insertar(sancion);
        }

        public int Modificar(int? idSancion, TipoSancion? tipo, DateTime? fecha, double? monto, DateTime? duracion, string descripcion, int? idPrestamo)
        {
            SancionDTO sancion = new SancionDTO
            {
                IdSancion = idSancion,
                Tipo = tipo,
                Fecha = fecha,
                Monto = monto,
                Duracion = duracion,
                Descripcion = descripcion,
                Prestamo = new PrestamoDTO { IdPrestamo = idPrestamo }
            };

            return this.sancionDAO.Modificar(sancion);
        }

        public int Eliminar(int? idSancion)
        {
            SancionDTO sancion = new SancionDTO
            {
                IdSancion = idSancion
            };

            return this.sancionDAO.Eliminar(sancion);
        }

        public SancionDTO ObtenerPorId(int? idSancion)
        {
            return this.sancionDAO.ObtenerPorId(idSancion);
        }

        public BindingList<SancionDTO> ListarTodos()
        {
            return this.sancionDAO.ListarTodos();
        }
    }
}
 
 */