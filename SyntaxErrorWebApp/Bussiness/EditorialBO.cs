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
    public class EditorialBO
    {
        private EditorialDAO editorialDAO;

        public EditorialBO()
        {
            this.editorialDAO = new EditorialDAOImpl();
        }

        public int Insertar(string nombre, string sitioWeb, string pais)
        {
            EditorialDTO editorial = new EditorialDTO();
            editorial.Nombre = nombre;
            editorial.SitioWeb = sitioWeb;
            editorial.Pais = pais;

            // Ejemplo validación opcional:
            // if (string.IsNullOrWhiteSpace(nombre))
            //    throw new ArgumentException("El nombre de la editorial no puede estar vacío.");

            return this.editorialDAO.Insertar(editorial);
        }

        public int Modificar(int? idEditorial, string nombre, string sitioWeb, string pais)
        {
            EditorialDTO editorial = new EditorialDTO();
            editorial.IdEditorial = idEditorial;
            editorial.Nombre = nombre;
            editorial.SitioWeb = sitioWeb;
            editorial.Pais = pais;
            return this.editorialDAO.Modificar(editorial);
        }

        public int Eliminar(int? idEditorial)
        {
            EditorialDTO editorial = new EditorialDTO();
            editorial.IdEditorial = idEditorial;
            return this.editorialDAO.Eliminar(editorial);
        }

        public EditorialDTO ObtenerPorId(int? idEditorial)
        {
            return this.editorialDAO.ObtenerPorId(idEditorial);
        }

        public BindingList<EditorialDTO> ListarTodos()
        {
            return this.editorialDAO.ListarTodos();
        }
    }
}

 */