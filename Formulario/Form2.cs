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

namespace FLAVIO_12_3A1.Formulario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        LoginDTO loDTO = new LoginDTO();
        LoginBLL loBLL = new LoginBLL();



        private void btn_login_Click(object sender, EventArgs e)
        {
            loDTO.Usuario = txt_email.Text;
            loDTO.Senha = txt_senha.Text;

            if (loBLL.RealizarLogin(loDTO) == true)
            {
                Form1 frmEPA = new Form1();
                frmEPA.ShowDialog();
            }



        }
    }
}
