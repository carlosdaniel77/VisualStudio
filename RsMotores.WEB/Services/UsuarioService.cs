using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RsMotores.WEB.Models;

namespace RsMotores.WEB.Services
{
    public class UsuarioService
    {
        private Usuario _usuario = new Usuario();

        public UsuarioService(Usuario model)
        {
            _usuario = model;
        }
        
        public bool ValidaCpf()
        {
            if(_usuario != null || 
                string.IsNullOrWhiteSpace(_usuario.cpf))
            {
                var aux = _usuario.cpf.Replace(".", "");
                aux = _usuario.cpf.Replace("-", "");
                aux = _usuario.cpf.Replace(" ", "");
                return aux.Length == 11;
            }
            else
            {
                return false;
            }
            
        }
    }
}
