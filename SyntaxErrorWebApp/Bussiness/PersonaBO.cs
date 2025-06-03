/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.UsuarioWS;

namespace Business
{
    public class PersonaBO
    {
        private PersonaWSClient personaClienteSOAP;

        public PersonaBO()
        {
            this.personaClienteSOAP = new PersonaWSClient();
        }

        public int Insertar(string nombre, string paterno, string materno, string direccion,
                           string telefono, string correo, string contrasenha, tipoPersona? tipo,
                           NivelDeIngles? nivel, Turnos? turno, DateTime? fechaContratoInicio,
                           DateTime? fechaContratoFinal, bool? vigente, SedeDTO sede)
        {
            

            return this.personaClienteSOAP.insertarPersona(nombre,paterno,materno,direccion,telefono,correo,
                contrasenha,tipo,nivel,turno,fechaContratoInicio,fechaContratoFinal,vigente,sede);
        }

        public int Modificar(int? idPersona, string nombre, string paterno, string materno, string direccion,
                            string telefono, string correo, string contrasenha, TipoPersona? tipo,
                            NivelDeIngles? nivel, Turnos? turno, DateTime? fechaContratoInicio,
                            DateTime? fechaContratoFinal, bool? vigente, SedeDTO sede)
        {
            return this.personaClienteSOAP.Modificar(idPersona,nombre,paterno,materno,direccion,telefono,correo,contras);
        }

        public int Eliminar(int? idPersona)
        {
            PersonaDTO persona = new PersonaDTO
            {
                IdPersona = idPersona
            };

            return this.personaDAO.Eliminar(persona);
        }

        public PersonaDTO ObtenerPorId(int? idPersona)
        {
            return this.personaDAO.ObtenerPorId(idPersona);
        }

        public BindingList<PersonaDTO> ListarTodos()
        {
            return this.personaDAO.ListarTodos();
        }
    }
}*/
