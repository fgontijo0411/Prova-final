using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLAVIO_12_3A1.Codigo.DAL;
using FLAVIO_12_3A1.Codigo.DTD;


namespace FLAVIO_12_3A1.Codigo.BLL
{
    class LoginBLL
    {
        AcessoBD conexao = new AcessoBD();
        string table = "login";
        public bool RealizarLogin(LoginDTO loginDTO)
        {
            string sql = $"select * from {table} where email = '{loginDTO.Usuario}' and senha = '{loginDTO.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
    }
}
