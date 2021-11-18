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
    class ChilibeansBLL
    {
        AcessoBD conexao = new AcessoBD();
        string table = "oculos";


        public void Inserir(chilibeansDTO oculosDTO)
        {
            string inserir = $"insert into {table} value (null, '{oculosDTO.Oculos}', '{oculosDTO.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(chilibeansDTO oculosDTO)
        {
            string alterar = $"update {table} set oculos = '{oculosDTO.Oculos}', preco = '{oculosDTO.Preco}'," +
                $" where id = '{oculosDTO.Id}'";
            conexao.ExecutarComando(alterar);
        }

        public void Exclui(chilibeansDTO oculosDTO)
        {
            string excluir = $"delete from {table} where id = '{oculosDTO.Id}'";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {table} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

    }
}
