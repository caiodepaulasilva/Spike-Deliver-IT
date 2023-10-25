using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova_Deliver_IT.Models
{
    public class Usuario
    {
        public int USU_Id { get; set; }
        public int USU_ENT_Id { get; set; }
        public string USU_Nome { get; set; }
        public string USU_Login { get; set; }
        public string USU_Senha { get; set; }
        public string USU_Bloqueado { get; set; }
        public DateTime USU_DataACesso { get; set; }
    }
}