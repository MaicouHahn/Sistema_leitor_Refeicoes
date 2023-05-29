using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Administrador
    {
        public string usuario { get;set;}
        public string senha { get;set;}
        public Administrador(string usuario, string senha) {
            this.usuario = usuario;
            this.senha = senha;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Administrador other = (Administrador)obj;
            return usuario == other.usuario && senha == other.senha;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + usuario.GetHashCode();
            hash = hash * 23 + senha.GetHashCode();
            return hash;
        }
    }
}
