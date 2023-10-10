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

namespace aula9lp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            //seta a string de conexão
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\22200552\Source\Repos\aula9lp1\aula9lp1\tabelas.mdf;Integrated Security=True";
            //abre a conexão
            cn.Open();
            //Cria o comando sql
            SqlCommand cmd = new SqlCommand();
            //string com sql
            string sqlQuery = "select IdPessoa, NomePessoa from Pessoa where Pessoa.IdCidade =" + comboBox1.SelectedValue;
            //passa a query para o comando e abre a conexão
            cmd = new SqlCommand(sqlQuery, cn);
            //cria o Sql Data Adapter
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            //cria Data Table
            DataTable dt = new DataTable();
            //Incializa SQL Data Adapter Command Property
            dAdapter.SelectCommand = cmd;
            //Preenche Data Table
            dAdapter.Fill(dt);
            //Popula Combo Box com os dados do Data Table
            comboBox3.DataSource = dt;
            //Seta combobox com o valor
            comboBox3.ValueMember = "IdPessoa";
            //seta combobox com descrição
            comboBox3.DisplayMember = "NomePessoa";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            //seta a string de conexão
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\22200552\Source\Repos\aula9lp1\aula9lp1\tabelas.mdf;Integrated Security=True";
            //abre a conexão
            cn.Open();
            //Cria o comando sql
            SqlCommand cmd = new SqlCommand();
            //string com sql
            string sqlQuery = "select IdPessoa, NomePessoa from Pessoa";
            //passa a query para o comando e abre a conexão
            cmd = new SqlCommand(sqlQuery, cn);
            //cria o Sql Data Adapter
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            //cria Data Table
            DataTable dt = new DataTable();
            //Incializa SQL Data Adapter Command Property
            dAdapter.SelectCommand = cmd;
            //Preenche Data Table
            dAdapter.Fill(dt);
            //Popula Combo Box com os dados do Data Table
            comboBox3.DataSource = dt;
            //Seta combobox com o valor
            comboBox3.ValueMember = "IdPessoa";
            //seta combobox com descrição
            comboBox3.DisplayMember = "NomePessoa";

            SqlCommand cmd2 = new SqlCommand();
            //string com sql
            string sqlQuery2 = "select IdEstadoCivil, Descricao from EstadoCivil";
            //passa a query para o comando e abre a conexão
            cmd2 = new SqlCommand(sqlQuery2, cn);
            //cria o Sql Data Adapter
            SqlDataAdapter dAdapter2 = new SqlDataAdapter();
            //cria Data Table
            DataTable dt2 = new DataTable();
            //Incializa SQL Data Adapter Command Property
            dAdapter.SelectCommand = cmd2;
            //Preenche Data Table
            dAdapter.Fill(dt2);
            //Popula Combo Box com os dados do Data Table
            comboBox2.DataSource = dt2;
            //Seta combobox com o valor
            comboBox2.ValueMember = "IdEstadoCivil";
            //seta combobox com descrição
            comboBox2.DisplayMember = "Descricao";

            SqlCommand cmd3 = new SqlCommand();
            //string com sql
            string sqlQuery3 = "select IdCidade, NomeCidade from Cidade";
            //passa a query para o comando e abre a conexão
            cmd3 = new SqlCommand(sqlQuery3, cn);
            //cria o Sql Data Adapter
            SqlDataAdapter dAdapter3 = new SqlDataAdapter();
            //cria Data Table
            DataTable dt3 = new DataTable();
            //Incializa SQL Data Adapter Command Property
            dAdapter.SelectCommand = cmd3;
            //Preenche Data Table
            dAdapter.Fill(dt3);
            //Popula Combo Box com os dados do Data Table
            comboBox1.DataSource = dt3;
            //Seta combobox com o valor
            comboBox1.ValueMember = "IdCidade";
            //seta combobox com descrição
            comboBox1.DisplayMember = "NomeCidade";

            SqlCommand cmd4 = new SqlCommand();
            //string com sql
            string sqlQuery4 = "select IdTipoPessoa, Descricao from TipoPessoa";
            //passa a query para o comando e abre a conexão
            cmd4 = new SqlCommand(sqlQuery4, cn);
            //cria o Sql Data Adapter
            SqlDataAdapter dAdapter4 = new SqlDataAdapter();
            //cria Data Table
            DataTable dt4 = new DataTable();
            //Incializa SQL Data Adapter Command Property
            dAdapter.SelectCommand = cmd4;
            //Preenche Data Table
            dAdapter.Fill(dt4);
            //Popula Combo Box com os dados do Data Table
            comboBox4.DataSource = dt4;
            //Seta combobox com o valor
            comboBox4.ValueMember = "IdTipoPessoa";
            //seta combobox com descrição
            comboBox4.DisplayMember = "Descricao";
        }
    }
}
