using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova_Deliver_IT.Models.DTO
{
    public class UsuarioDTO
    {
        public int USU_Id { get; set; }
        public Entidade Entidade { get; set; }        
        public string USU_Nome { get; set; }
        public string USU_Login { get; set; }
        public string USU_Senha { get; set; }
        public string USU_Bloqueado { get; set; }
        public DateTime USU_DataACesso { get; set; }
    }
}