using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova_Deliver_IT.Models.DTO
{
    public class PerfilDTO
    {
        public int PER_Id { get; set; }
        public Sistema Sistema { get; set; }
        public string PER_Nome { get; set; }
    }
}