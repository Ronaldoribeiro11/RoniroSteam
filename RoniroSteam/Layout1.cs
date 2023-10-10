using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RoniroSteam
{
    public partial class Layout1 : Form
    {
        public Layout1()
        {
            InitializeComponent();
        }

        private void Txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Conecte conecte = new Conecte();
            SqlCommand command = new SqlCommand();
            command.Connection = conecte.ReturnConnection();


            command.CommandText = "SELECT * FROM CadastroSteam WHERE Nome = @Nome AND Senha = @Senha";

            command.Parameters.AddWithValue("@Nome", txt1.Text);
            command.Parameters.AddWithValue("@Senha", txt2.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // O nome de usuário e a senha estão corretos
                // Abrir o próximo formulário
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                // O nome de usuário e a senha estão incorretos
                MessageBox.Show("Nome de usuário ou senha inválidos");
            }

       
    }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          Cadastro cadastro = new Cadastro();
            cadastro.Show();
            Layout1 layout1 = new Layout1();
            layout1.Hide();

        }
    }
    namespace AutenticacaoDeUsuario
    {
        public partial class LoginForm : Form
        {
            




            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void Cadastrar_KeyPress(object sender, KeyPressEventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                Cadastro Layout1 = new Cadastro();
                Layout1.Show();
            }

            private void label1_Click_2(object sender, EventArgs e)
            {

            }

            
                    
                    }
               }
            }
       
    















