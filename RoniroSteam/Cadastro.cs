using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoniroSteam
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool IsValidPhoneNumber(string telefone)
        {
            // Define a expressão regular para validar um número de telefone no formato (99) 99999-9999
            string pattern = @"^\(\d{2}\)\d{5}-\d{4}$";

            // Cria um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Usa o método Match para verificar se o telefone corresponde ao padrão
            return regex.IsMatch(telefone);
        }

        private bool IsValidEmail(string email)
        {
            // Define a expressão regular para validar um endereço de e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Cria um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Usa o método Match para verificar se o email corresponde ao padrão
            return regex.IsMatch(email);
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string email = txt2.Text;

            Conecte conecte = new Conecte();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = conecte.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO CadastroSteam VALUES (@Nome, @Email, @NumeroCell, @senha)";

            sqlCommand.Parameters.AddWithValue("@Nome", txt1.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txt2.Text);
            sqlCommand.Parameters.AddWithValue("@NumeroCell", txtm.Text);
            sqlCommand.Parameters.AddWithValue("@Senha", txt4.Text);



            string telefone = txtm.Text;

            if (IsValidPhoneNumber(telefone))
            {
                if (IsValidEmail(email))
                {
                    if (string.IsNullOrWhiteSpace(txt1.Text))
                    {
                        MessageBox.Show("Digite o Nome");
                        txt1.Clear();
                        if (string.IsNullOrWhiteSpace(txt4.Text))
                        {
                            MessageBox.Show("Digite a senha");
                            txt2.Clear();
                        }
                    }
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastrar com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txt1.Clear();
                    txt2.Clear();
                    txt4.Clear();
                    txtm.Clear();
                    Layout1 cadastro = new Layout1();
                    cadastro.Hide();
                }
                else
                {
                    MessageBox.Show("O endereço de E-mail é inválido");
                    txt2.Clear();
                }

            }
            else
            {
                MessageBox.Show("O Numero de telefone é inválido");
                txtm.Clear();
            }
            
            

            
            



            //    string name = txt1.Text, email = txt2.Text, numero = txtm.Text, senha = txt4.Text;

            //    MessageBox.Show(
            //        "Nome: " + name +
            //        "\nEmail: " + email +
            //        "\nnumero: " + numero +
            //        "\nsenha: " + senha,
            //        "\ninformaçoes");

            //    Login Layout1 = new Login();
            //    Layout1.Show();


        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
