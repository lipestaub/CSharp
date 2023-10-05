using Entidades.Pessoas;
using BaseDeDados.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Sistema;
using Entidades.Enumeradores;

namespace Negocio.Pessoas
{
    public class ClienteNG
    {
        private readonly ClienteBD _bd;

        public ClienteNG()
        {
            _bd = new ClienteBD();
        }

        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string nome)
        {
            return _bd.ListarPesquisaCliente(status, nome);
        }

        public Cliente Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }
    }
}
