using BaseDeDados.Pessoas;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Pessoas
{
    public class TipoUsuarioNG
    {
        private readonly TipoUsuarioBD _bd;

        public TipoUsuarioNG()
        {
            _bd = new TipoUsuarioBD();
        }

        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigoUsuario)
        {
            return _bd.BuscarTipoUsuarioDoUsuario(codigoUsuario);
        }

        public TipoUsuario Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }
    }
}
