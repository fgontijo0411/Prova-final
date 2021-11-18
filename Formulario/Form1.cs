using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLAVIO_12_3A1.Codigo.BLL;
using FLAVIO_12_3A1.Codigo.DTD;


namespace FLAVIO_12_3A1
{
    public partial class Form1 : Form
    {

        chilibeansDTO oculosDTO = new chilibeansDTO();
        ChilibeansBLL oculosBLL = new ChilibeansBLL();
        public Form1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_oculos.DataSource = oculosBLL.Listar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            oculosDTO.Oculos = txt_oculos.Text;
            oculosDTO.Preco = double.Parse(txt_preco.Text);

           oculosBLL.Inserir(oculosDTO);

            MessageBox.Show("Concluido!");

            oculosBLL.Listar();





        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            oculosDTO.Id = int.Parse(txt_id.Text);
            oculosDTO.Oculos = txt_oculos.Text;
            oculosDTO.Preco = double.Parse(txt_preco.Text);

            oculosBLL.Editar(oculosDTO);

            MessageBox.Show("Concluido!");

            oculosBLL.Listar();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            oculosDTO.Id = int.Parse(txt_id.Text);
            oculosBLL.Exclui(oculosDTO);
            MessageBox.Show("Concluido!");
            oculosBLL.Listar();
        }
    }
}
