using BaseDeDados.Produtos;
using Entidades.Enumeradores;
using Entidades.Produtos;
using Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Produtos
{
    public class AdicionalNG
    {
        private readonly AdicionalBD _bd;

        public AdicionalNG()
        {
            _bd = new AdicionalBD();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        public Adicional Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }

    }
}
