using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sistema
{
    public class ComboBoxItemUsuario
    {
        public string Login;
        public int Codigo;
        public string Senha;

        public ComboBoxItemUsuario(string login, int codigo, string senha)
        {
            Login = login;
            Codigo = codigo;
            Senha = senha;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}
