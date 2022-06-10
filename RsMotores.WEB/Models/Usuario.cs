using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.WEB.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nome;
        public string cpf;
        public string email;
        public string password;

        public bool ValidaCpf(string dados)
        {
            var aux = dados.Replace(".", "");
            aux = dados.Replace("-", "");
            aux = dados.Replace(" ", "");
            //if (aux.Length == 11)
            //{
            //    return true;
            //}
            //else
            //{
            //   return false;
            //}

            return aux.Length == 11;
        }
    }
}
