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
    public class CreadorBO
    {
        private CreadorDAO creadorDAO;

        public CreadorBO()
        {
            this.creadorDAO = new CreadorDAOImpl();
        }

        public int Insertar(string nombre, string paterno, string materno,
                            string seudonimo, TipoAutor tipo, string nacionalidad, bool activo)
        {
            CreadorDTO creador = new CreadorDTO();
            creador.Nombre = nombre;
            creador.Paterno = paterno;
            creador.Materno = materno;
            creador.Seudonimo = seudonimo;
            creador.Tipo = tipo;
            creador.Nacionalidad = nacionalidad;
            creador.Activo = activo;
            return this.creadorDAO.Insertar(creador);
        }

        public int Modificar(string nombre, string paterno, string materno,
                             string seudonimo, TipoAutor tipo, string nacionalidad, bool activo)
        {
            CreadorDTO creador = new CreadorDTO();
            creador.Nombre = nombre;
            creador.Paterno = paterno;
            creador.Materno = materno;
            creador.Seudonimo = seudonimo;
            creador.Tipo = tipo;
            creador.Nacionalidad = nacionalidad;
            creador.Activo = activo;
            return this.creadorDAO.Modificar(creador);
        }

        public int Eliminar(int idCreador)
        {
            CreadorDTO creador = new CreadorDTO();
            creador.IdAutor = idCreador;
            return this.creadorDAO.Eliminar(creador);
        }

        public CreadorDTO ObtenerPorId(int idCreador)
        {
            return this.creadorDAO.ObtenerPorId(idCreador);
        }

        public BindingList<CreadorDTO> ListarTodos()
        {
            return this.creadorDAO.ListarTodos();
        }
    }
}

 */