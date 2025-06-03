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
    public class EjemplarBO
    {
        private EjemplarDAO ejemplarDAO;
        private SedeDAO sedeDAO;
        private MaterialDAO materialDAO;

        public EjemplarBO()
        {
            this.ejemplarDAO = new EjemplarDAOImpl();
            this.sedeDAO = new SedeDAOImpl();
            this.materialDAO = new MaterialDAOImpl();
        }

        public int Insertar(DateTime? fechaAdquisicion, bool? disponible, TipoEjemplar? tipo,
                           FormatoDigital? formatoDigital, string ubicacion,
                           int? idSede, int? idMaterial)
        {
            EjemplarDTO ejemplar = new EjemplarDTO
            {
                FechaAdquisicion = fechaAdquisicion,
                Disponible = disponible,
                Tipo = tipo,
                FormatoDigital = formatoDigital,
                Ubicacion = ubicacion
            };

            SedeDTO sede = this.sedeDAO.ObtenerPorId(idSede);
            if (sede != null)
            {
                sede.IdSede = idSede;
                ejemplar.Sede = sede;
            }

            MaterialDTO material = this.materialDAO.ObtenerPorId(idMaterial);
            if (material != null)
            {
                material.IdMaterial = idMaterial;
                ejemplar.Material = material;
            }

            return this.ejemplarDAO.Insertar(ejemplar);
        }

        public int Modificar(int? idEjemplar, DateTime? fechaAdquisicion, bool? disponible,
                             TipoEjemplar? tipo, FormatoDigital? formatoDigital, string ubicacion,
                             int? idSede, int? idMaterial)
        {
            EjemplarDTO ejemplar = new EjemplarDTO
            {
                IdEjemplar = idEjemplar,
                FechaAdquisicion = fechaAdquisicion,
                Disponible = disponible,
                Tipo = tipo,
                FormatoDigital = formatoDigital,
                Ubicacion = ubicacion
            };

            SedeDTO sede = this.sedeDAO.ObtenerPorId(idSede);
            if (sede != null)
            {
                sede.IdSede = idSede;
                ejemplar.Sede = sede;
            }

            MaterialDTO material = this.materialDAO.ObtenerPorId(idMaterial);
            if (material != null)
            {
                material.IdMaterial = idMaterial;
                ejemplar.Material = material;
            }

            return this.ejemplarDAO.Modificar(ejemplar);
        }

        public int Eliminar(int? idEjemplar)
        {
            EjemplarDTO ejemplar = new EjemplarDTO
            {
                IdEjemplar = idEjemplar
            };
            return this.ejemplarDAO.Eliminar(ejemplar);
        }

        public EjemplarDTO ObtenerPorId(int? idEjemplar)
        {
            return this.ejemplarDAO.ObtenerPorId(idEjemplar);
        }

        public BindingList<EjemplarDTO> ListarTodos()
        {
            return this.ejemplarDAO.ListarTodos();
        }
    }
}

 */