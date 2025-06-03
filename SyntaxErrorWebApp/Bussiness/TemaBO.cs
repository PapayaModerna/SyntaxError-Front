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
    public class TemaBO
    {
        private TemaDAO temaDAO;

        public TemaBO()
        {
            this.temaDAO = new TemaDAOImpl();
        }

        public int Insertar(string descripcion, Categoria? categoria, int? idTemaPadre)
        {
            TemaDTO tema = new TemaDTO
            {
                Descripcion = descripcion,
                Categoria = categoria
            };

            if (idTemaPadre != null)
            {
                TemaDTO temaPadre = new TemaDTO { IdTema = idTemaPadre };
                tema.TemaPadre = temaPadre;
            }

            return this.temaDAO.Insertar(tema);
        }

        public int Modificar(int? idTema, string descripcion, Categoria? categoria, int? idTemaPadre)
        {
            TemaDTO tema = new TemaDTO
            {
                IdTema = idTema,
                Descripcion = descripcion,
                Categoria = categoria
            };

            if (idTemaPadre != null)
            {
                TemaDTO temaPadre = new TemaDTO { IdTema = idTemaPadre };
                tema.TemaPadre = temaPadre;
            }

            return this.temaDAO.Modificar(tema);
        }

        public int Eliminar(int? idTema)
        {
            TemaDTO tema = new TemaDTO { IdTema = idTema };
            return this.temaDAO.Eliminar(tema);
        }

        public TemaDTO ObtenerPorId(int? idTema)
        {
            return this.temaDAO.ObtenerPorId(idTema);
        }

        public BindingList<TemaDTO> ListarTodos()
        {
            return this.temaDAO.ListarTodos();
        }
    }
}

 */