using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RoniroSteam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            tabelinha.Visible = false;
            painelSenha.Visible = true;

        }
        private void UpdateListView()
        {
            tabelinha.Items.Clear();

            Conecte conn = new Conecte();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM CadastroSteam";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["Nome"];
                    string Email = (string)dr["Email"];
                    string tel = (string)dr["NumeroCell"];
                    string Senha = (string)dr["Senha"];
                  

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(Email);
                    lv.SubItems.Add(tel);
                    lv.SubItems.Add(Senha);
                    tabelinha.Items.Add(lv);
                    //foi

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void tabelinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            string login = textSenha.Text;
            if (login == "rere4321")
            {
                tabelinha.Visible = true;
                painelSenha.Visible = false;
            }
        }

        private void tabelinha_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = tabelinha.FocusedItem.Index;
            
            int id = int.Parse(tabelinha.Items[index].SubItems[0].Text);
            string nome = tabelinha.Items[index].SubItems[1].Text;
            string email = tabelinha.Items[index].SubItems[2].Text;
            string numerocell = tabelinha.Items[index].SubItems[3].Text;
            string senha = tabelinha.Items[index].SubItems[4].Text;
            Usuario usuario = new Usuario(id, nome, email, numerocell, senha);

            Cadastro cad = new Cadastro(usuario);
            cad.Show();
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
