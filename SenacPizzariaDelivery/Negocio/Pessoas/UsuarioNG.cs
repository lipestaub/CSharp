using BaseDeDados;
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
    public class UsuarioNG
    {
        private readonly UsuarioBD _bd;
        private readonly FuncoesBD _funcoesbd;

        public UsuarioNG()
        {
            _bd = new UsuarioBD();
            _funcoesbd = new FuncoesBD();
        }

        public List<Usuario> ListarUsuarios()
        {
            return _bd.ListarUsuarios();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        public Usuario Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }

        public int BuscarProximoCodigo()
        {
            return _funcoesbd.BuscarProximoCodigo("SHOW TABLE STATUS LIKE 'usuario';");
        }

        public bool Inserir(Usuario usuario)
        {
            return _bd.Inserir(usuario);
        }

        public bool Atualizar(Usuario usuario)
        {
            return _bd.Atualizar(usuario);
        }

        public bool Excluir(int codigo)
        {
            return _bd.Excluir(codigo);
        }

    }
}
