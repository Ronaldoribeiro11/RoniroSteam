using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RoniroSteam
{
    public class Usuario
    {
        public int Id;
        public string nome;
        public string email;
        public string numerocell;
        public string senha;
        public Usuario(int id, string nome, string email, string numerocell, string senha)
        {
            Id = id;
            this.nome = nome;
            this.email = email;
            this.numerocell = numerocell;
            this.senha = senha;
        }
    }
}
