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
    public class MaterialBO
    {
        private MaterialDAO materialDAO;
        private EditorialDAO editorialDAO;

        public MaterialBO()
        {
            this.materialDAO = new MaterialDAOImpl();
            this.editorialDAO = new EditorialDAOImpl();
        }

        public int Insertar(string titulo, string edicion, NivelDeIngles nivel, int? anioPublicacion, int? idEditorial)
        {
            MaterialDTO material = new MaterialDTO
            {
                Titulo = titulo,
                Edicion = edicion,
                Nivel = nivel,
                AnioPublicacion = anioPublicacion
            };

            EditorialDTO editorial = this.editorialDAO.ObtenerPorId(idEditorial);
            if (editorial != null)
            {
                editorial.IdEditorial = idEditorial;
                material.Editorial = editorial;
            }

            return this.materialDAO.Insertar(material);
        }

        public int Modificar(int? idMaterial, string titulo, string edicion, NivelDeIngles nivel, int? anioPublicacion, int? idEditorial)
        {
            MaterialDTO material = new MaterialDTO
            {
                IdMaterial = idMaterial,
                Titulo = titulo,
                Edicion = edicion,
                Nivel = nivel,
                AnioPublicacion = anioPublicacion
            };

            EditorialDTO editorial = this.editorialDAO.ObtenerPorId(idEditorial);
            if (editorial != null)
            {
                editorial.IdEditorial = idEditorial;
                material.Editorial = editorial;
            }

            return this.materialDAO.Modificar(material);
        }

        public int Eliminar(int idMaterial)
        {
            MaterialDTO material = new MaterialDTO
            {
                IdMaterial = idMaterial
            };
            return this.materialDAO.Eliminar(material);
        }

        public MaterialDTO ObtenerPorId(int? idMaterial)
        {
            return this.materialDAO.ObtenerPorId(idMaterial);
        }

        public BindingList<MaterialDTO> ListarTodos()
        {
            return this.materialDAO.ListarTodos();
        }
    }
}

 */