using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova_Deliver_IT.Models
{
    public class Entidade
    {
        public int ENT_Id { get; set; }
        public string ENT_Nome { get; set; }
        public string ENT_Responsável { get; set; }
        public int ENT_TerminalPrefixo { get; set; }
    }
}