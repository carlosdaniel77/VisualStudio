using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.WEB.Models
{
    public class ErrorMessage
    {
        public string msg;
        
        /// <summary>
        /// Coloca uma mensagem de erro na variável msg 
        /// 1 - Erro de Login,
        /// 2 - Erro de Cpf, 
        /// 3 - Erro de Campos em branco;
        /// </summary>
        /// <param name="tipo"></param>
        public ErrorMessage(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    msg = "Login inválido. Email e senha não encontrados!";
                    break;

                case 2:
                    msg = "Cpf inválido. O cpf informado está inválido!";
                    break;
                case 3:
                    msg = "Campos: Email e senha não podem ser vazios!";
                    break;
                default:
                    msg = "Erro não reconhecido. Entrar em contato com suporte admin@admin.";
                    break;
            }
        }
    }
}
