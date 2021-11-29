using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Eletrodoméstico");
            comboBox1.Items.Add("Informática");
            comboBox1.Items.Add("Movéis");
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Passa a string de conexão
                MySqlConnection objetodeconexao = new MySqlConnection("server=localhost;port=3306; User Id=root; database=bd_estoque;password=");

                objetodeconexao.Open();
                //MessageBox.Show("Conectado");
          
                MySqlCommand objCmd = new MySqlCommand("insert into produto(nome, valor, descricao, quantidade, tipo) values (?, ?, ?, ?, ?);", objetodeconexao);

                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = nome.Text;
                objCmd.Parameters.Add("@valor", MySqlDbType.Float, 14).Value = textBox1.Text;
                objCmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 45).Value = textBox2.Text;
                objCmd.Parameters.Add("@quantidade", MySqlDbType.Int32, 11).Value = textBox3.Text;
                objCmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = comboBox1.SelectedItem.ToString();

                //Comando para executar query
                objCmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso");

                //Fecha a conexão com o banco de dados
                objetodeconexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não conectou " + erro);
            }

        }

        private void remover_Click(object sender, EventArgs e)
        {
            try
            {
                //Passa a string de conexão
                MySqlConnection objetodeconexao = new MySqlConnection("server=localhost;port=3306; User Id=root; database=bd_estoque;password=");

                //Abre o banco de dados
                objetodeconexao.Open();
                //MessageBox.Show("Conectado");

                //Comando para inserir dados na tabela
                MySqlCommand objCmd = new MySqlCommand("delete from produto where produto.id = ?;", objetodeconexao);

                //Parâmetros dos comandos Sql
                objCmd.Parameters.Add("@id", MySqlDbType.Int32, 11).Value = IdBox.Text;
                //objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = nome.Text;
                //objCmd.Parameters.Add("@valor", MySqlDbType.Float, 14).Value = textBox1.Text;
                //objCmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 45).Value = textBox2.Text;
                //objCmd.Parameters.Add("@quantidade", MySqlDbType.Int32, 11).Value = textBox3.Text;
                //objCmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = comboBox1.SelectedItem.ToString();

                //Comando para executar query
                objCmd.ExecuteNonQuery();
                MessageBox.Show("Remoção realizada com sucesso");

                //Fecha a conexão com o banco de dados
                objetodeconexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não conectou " + erro);
            }
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //Passa a string de conexão
                MySqlConnection objetodeconexao = new MySqlConnection("server=localhost;port=3306; User Id=root; database=bd_estoque;password=");

                //Abre o banco de dados
                objetodeconexao.Open();
                //MessageBox.Show("Conectado");

                //Comando para inserir dados na tabela
                MySqlCommand objCmd = new MySqlCommand("update produto set quantidade = ?, descricao = ?, valor = ? where produto.id = ?;", objetodeconexao);

                //Parâmetros dos comandos Sql
                objCmd.Parameters.Add("@quantidade", MySqlDbType.Int32, 11).Value = textBox3.Text;
                objCmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 45).Value = textBox2.Text;     
                objCmd.Parameters.Add("@valor", MySqlDbType.Float, 14).Value = textBox1.Text;
                objCmd.Parameters.Add("@id", MySqlDbType.Int32, 11).Value = IdBox.Text;
                //.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = nome.Text;

                //objCmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 45).Value = textBox2.Text;
                //objCmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = comboBox1.SelectedItem.ToString();

                //Comando para executar query
                objCmd.ExecuteNonQuery();
                MessageBox.Show("Alteração realizada com sucesso");

                //Fecha a conexão com o banco de dados
                objetodeconexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não conectou " + erro);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
