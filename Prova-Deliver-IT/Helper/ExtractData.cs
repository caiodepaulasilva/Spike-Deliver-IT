using Prova_Deliver_IT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova_Deliver_IT.Helper
{
    public class ExtractData
    {
        public List<Entidade> ExtractEntidade(DataTable dataTable)
        {
            return (from row in dataTable.AsEnumerable()
                    select new Entidade
                    {
                        ENT_Id = Convert.ToInt32(row["ENT_Id"]),
                        ENT_Nome = Convert.ToString(row["ENT_Nome"]),
                        ENT_Responsavel = Convert.ToString(row["ENT_Responsavel"]),
                        ENT_TerminalPrefixo = Convert.ToInt32(row["ENT_TerminalPrefixo"]),
                    }
                    ).ToList();
        }

        public List<Usuario> ExtractUsuario(DataTable dataTable)
        {
            return (from row in dataTable.AsEnumerable()
                    select new Usuario
                    {
                        USU_Id = Convert.ToInt32(row["USU_Id"]),
                        USU_ENT_Id = Convert.ToInt32(row["USU_ENT_Id"]),
                        USU_Login = Convert.ToString(row["USU_Login"]),
                        USU_Nome = Convert.ToString(row["USU_Nome"]),
                        USU_Senha = Convert.ToString(row["USU_Senha"]),
                        USU_Bloqueado = Convert.ToString(row["USU_Bloqueado"]),
                        USU_DataACesso = Convert.ToDateTime(row["USU_DataACesso"])
                    }
                    ).ToList();
        }

        public List<Perfil> ExtractPerfil(DataTable dataTable)
        {
            return (from row in dataTable.AsEnumerable()
                    select new Perfil
                    {
                        PER_Id = Convert.ToInt32(row["PER_Id"]),
                        PER_Nome = Convert.ToString(row["PER_Nome"]),
                        PER_SIS_Id = Convert.ToInt32(row["PER_SIS_Id"])
                    }
                    ).ToList();
        }

        public List<Sistema> ExtractSistema(DataTable dataTable)
        {
            return (from row in dataTable.AsEnumerable()
                    select new Sistema
                    {
                        SIS_Id = Convert.ToInt32(row["SIS_Id"]),
                        SIS_Nome = Convert.ToString(row["SIS_Nome"]),
                        SIS_Link = Convert.ToString(row["SIS_Link"])
                    }
                    ).ToList();
        }

        public List<UsuarioPerfil> ExtractUsuarioPerfil(DataTable dataTable)
        {
            return (from row in dataTable.AsEnumerable()
                    select new UsuarioPerfil
                    {
                        USP_PER_Id = Convert.ToInt32(row["USP_PER_Id"]),
                        USP_USU_Id = Convert.ToInt32(row["USP_USU_Id"])
                    }
                    ).ToList();
        }
    }
}