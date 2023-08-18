using MySql.Data.MySqlClient;
using System.Data;

namespace ControleDeDados
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=db_agenda";
        private int ?id_contato_selecionado = null;
        public Form1()
        {
            InitializeComponent();

            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines = true;

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Email", 150, HorizontalAlignment.Left);

            carregar_contatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //criar conexao

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;



                if(id_contato_selecionado == null)
                {
                    cmd.CommandText = "INSERT INTO contato (nome, telefone, email)" +
                    "VALUES " +
                    "(@nome, @telefone, @telefone) ";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato inserido com sucesso!",
                                     "Sucesso",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                } else
                {
                    cmd.CommandText = "UPDATE contato SET nome=@nome, telefone=@telefone, email=@email WHERE id = @id";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato atualizado com sucesso!",
                                     "Sucesso",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }

                txtNome.Text = String.Empty;
                txtTelefone.Text = String.Empty;
                txtEmail.Text = String.Empty;

                carregar_contatos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            finally { Conexao.Close(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscar.Text + "%'";
                //criar conexao
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM contato " +
                    "WHERE nome LIKE " + q + "OR email LIKE " + q;

                //executar comando com insert
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    var linha_listview = new ListViewItem(row);

                    lst_contatos.Items.Add(linha_listview);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexao.Close(); }
        }

        private void carregar_contatos()
        {
            try
            {
                //criar conexao
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * " +
                    "FROM contato " +
                    "ORDER BY id DESC";
                cmd.Prepare();

                //executar comando com insert
                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    var linha_listview = new ListViewItem(row);

                    lst_contatos.Items.Add(linha_listview);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexao.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lst_contatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_contatos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtTelefone.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;

            }
            
        }
    }
}