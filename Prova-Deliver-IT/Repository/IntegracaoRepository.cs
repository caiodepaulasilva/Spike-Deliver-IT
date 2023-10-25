using Dapper;
using Microsoft.Extensions.Configuration;
using Prova_Deliver_IT.Models;
using Prova_Deliver_IT.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Prova_Deliver_IT.Repository
{
    public class IntegracaoRepository
    {        
        private readonly string connectionString;

        public IntegracaoRepository()
        {
            //connectionString = confugration["Connectionstrings:SQL_Server"];

            //TODO:
            //Incluir injeção de dependêncioa para permitir usar o IConfiguration para extração de dados do arquivo de configuração
            //Criar uma interface para a classe
            //Criar cada um dos métodos de Insert faltantes (Usuario, Perfil, UsuarioPerfil, Sistema e Entidade)
        }

        public async Task<UsuarioDTO> GetUsuario(int usu_id, int usu_ent_id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync(
                    @"SELECT *
                    FROM ADM_Usuario
                    JOIN ADM_Entidade ON ADM_Usuario.USU_ENT_Id = ADM_Entidade.ENT_id
                    JOIN ADM_UsuarioXPerfil ON ADM_Usuario.USU_Id = ADM_UsuarioXPerfil.USP_USU_Id
                    JOIN ADM_Perfil ON ADM_UsuarioXPerfil.USU_PER_Id = ADM_Perfil.PER_Id
                    JOIN ADM_Sistema ON ADM_Perfil.PER_SIS_Id = ADM_Sistema.SIS_Id
                    WHERE ADM_Usuario.USU_Id @usu_id = AND ADM_Usuario.USU_ENT_Id = @usu_ent_id",
                    (
                        usu_id,
                        usu_ent_id
                    )
                );
            }
        }
    }
}