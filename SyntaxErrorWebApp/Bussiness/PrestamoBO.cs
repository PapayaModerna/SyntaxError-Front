/*
 using Model;
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
    public class PrestamoBO
    {
        private PrestamoDAO prestamoDAO;

        public PrestamoBO()
        {
            this.prestamoDAO = new PrestamoDAOImpl();
        }

        public int Insertar(DateTime? fechaSolicitud, DateTime? fechaPrestamo, DateTime? fechaDevolucion, int? idPersona)
        {
            PrestamoDTO prestamo = new PrestamoDTO
            {
                FechaSolicitud = fechaSolicitud,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion,
                Persona = new PersonaDTO { IdPersona = idPersona }
            };

            return this.prestamoDAO.Insertar(prestamo);
        }

        public int Modificar(int? idPrestamo, DateTime? fechaSolicitud, DateTime? fechaPrestamo, DateTime? fechaDevolucion, int? idPersona)
        {
            PrestamoDTO prestamo = new PrestamoDTO
            {
                IdPrestamo = idPrestamo,
                FechaSolicitud = fechaSolicitud,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion,
                Persona = new PersonaDTO { IdPersona = idPersona }
            };

            return this.prestamoDAO.Modificar(prestamo);
        }

        public int Eliminar(int? idPrestamo)
        {
            PrestamoDTO prestamo = new PrestamoDTO
            {
                IdPrestamo = idPrestamo
            };

            return this.prestamoDAO.Eliminar(prestamo);
        }

        public PrestamoDTO ObtenerPorId(int? idPrestamo)
        {
            return this.prestamoDAO.ObtenerPorId(idPrestamo);
        }

        public BindingList<PrestamoDTO> ListarTodos()
        {
            return this.prestamoDAO.ListarTodos();
        }
    }
}

 */
