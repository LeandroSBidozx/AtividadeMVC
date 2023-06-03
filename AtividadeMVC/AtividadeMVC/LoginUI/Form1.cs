using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeMVC.BLL;
using AtividadeMVC.DTO;
using AtividadeMVC.DAL;


namespace AtvidadeMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBox1_Click(object sender, EventArgs e)
        {

        }

        private void tBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Criar objeto da DTO
            LoginDTO loginDTO = new LoginDTO
            {
                Email = tBox1.Text,
                Senha = tBox2.Text
            };

            //Criar objeto da BLL
            LoginBLL loginBLL = new LoginBLL();


            //Chamar a BLL
            bool retorno = loginBLL.GetLoginBLL(loginDTO);

            if (retorno)
            {
                MessageBox.Show("Login OK");
            }
            else
            {
                MessageBox.Show("Falha no login");
            }
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            {
                //Criar objeto da DTO
                LoginDTO loginDTO = new LoginDTO
                {
                    Email = tBox1.Text,
                    Senha = tBox2.Text
                };

                //Criar objeto da BLL
                LoginBLL loginBLL = new LoginBLL();


                //Chamar a BLL
                bool retorno = loginBLL.GetLoginBLL(loginDTO);

                if (retorno)
                {
                    MessageBox.Show("Login OK");
                }
                else
                {
                    MessageBox.Show("Falha no login");
                }
            }

        }
    }
}
