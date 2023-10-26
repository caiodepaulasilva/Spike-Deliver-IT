using Prova_Deliver_IT.Helper;
using Prova_Deliver_IT.Models;
using Prova_Deliver_IT.Models.DTO;
using Prova_Deliver_IT.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova_Deliver_IT
{
    public partial class _Default : Page
    {
        private readonly ExtractData _extractData = new ExtractData();
        private readonly IntegracaoRepository _integracaoRepository = new IntegracaoRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Server.MapPath("~/integracao.xml"));

                List<Usuario> users = _extractData.ExtractUsuario(dataSet.Tables["ADM_Usuario"]);
                //TODO: Incluir método de insert-users-to-repository

                List<UsuarioPerfil> userProfiles = _extractData.ExtractUsuarioPerfil(dataSet.Tables["ADM_UsuarioPerfil"]);
                //TODO: Incluir método de insert-userProfiles-to-repository

                List<Perfil> profiles = _extractData.ExtractPerfil(dataSet.Tables["ADM_Perfil"]);
                //TODO: Incluir método de insert-profiles-to-repository

                List<Sistema> systems = _extractData.ExtractSistema(dataSet.Tables["ADM_Sistema"]);
                //TODO: Incluir método de insert-systems-to-repository

                List<Entidade> entities = _extractData.ExtractEntidade(dataSet.Tables["ADM_Entidade"]);
                //TODO: Incluir método de insert-entities-to-repository

                //TODO: Quando a lógica de inserção no banco estiver funcionando será possível fazer a extração do usuário pelo método GetUsersWithDependencies(users);

                //De outra forma, os dados serão exibidos no GridView exatamente como foram extraídos do XML.                

                Usuarios.DataSource = users;
                Entidades.DataSource = entities;

                Usuarios.DataBind();
                Entidades.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }

        private async Task<List<UsuarioDTO>> GetUserWithDependencie(List<Usuario> users)
        {
            List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();

            foreach (Usuario user in users)
            {
                UsuarioDTO userWithDependecie = await _integracaoRepository.GetUsuario(user.USU_Id, user.USU_ENT_Id);
                usuariosDTO.Add(userWithDependecie);
            }
            return usuariosDTO;
        }
    }
}