using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElesElas
{
    public partial class Form1 : Form
    {
        const int numProfissoes= 4;
        const int numCartoes= 20;
        string[] listaProfissoes = new string[] { "Educador(a) de Infância", "mecânico(a)", "assistente de bordo", "motorista" };
        string[,] listaPessoas = new string[numCartoes, 7];
        int pessoaAtual;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i, j;
            string path = "people.csv";

            string[] lines = System.IO.File.ReadAllLines(path);
            i = 0;
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                j = 0;
                foreach (string column in columns)
                {
                    labelProfissao.Text = column;
                    listaPessoas[i, j] = column;
                    j += 1;
                }
                i += 1;
            }
            panel1.Visible = false;
            panel2.Visible = false;
            buttonLeft.Visible = false;
            buttonRight.Visible = false;

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
           
            pessoaAtual=(pessoaAtual+1)% 20;
            labelProfissao.Text = pessoaAtual.ToString();
            nomePessoa2.Text = listaPessoas[pessoaAtual, 0];
            idadePessoa2.Text = listaPessoas[pessoaAtual, 1];
            generoPessoa2.Text = listaPessoas[pessoaAtual, 2];
            habilitacoesPessoa2.Text = listaPessoas[pessoaAtual, 4];
            experienciaPessoa2.Text = listaPessoas[pessoaAtual, 5];
            pontosPessoa2.Text = listaPessoas[pessoaAtual, 6];

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            
            pessoaAtual = (20+pessoaAtual - 1) % 20;
            labelProfissao.Text = pessoaAtual.ToString();
            nomePessoa2.Text = listaPessoas[pessoaAtual, 0];
            idadePessoa2.Text = listaPessoas[pessoaAtual, 1];
            generoPessoa2.Text = listaPessoas[pessoaAtual, 2];
            habilitacoesPessoa2.Text = listaPessoas[pessoaAtual, 4];
            experienciaPessoa2.Text = listaPessoas[pessoaAtual, 5];
            pontosPessoa2.Text = listaPessoas[pessoaAtual, 6];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.None;

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            

        }

        private void exibirNovoPar()
        {

            pessoaAtual = (pessoaAtual + 1) % 20;
            labelProfissao.Text = listaPessoas[pessoaAtual, 3];
            nomePessoa2.Text = listaPessoas[pessoaAtual, 0];
            idadePessoa2.Text = listaPessoas[pessoaAtual, 1];
            generoPessoa2.Text = listaPessoas[pessoaAtual, 2];
            habilitacoesPessoa2.Text = listaPessoas[pessoaAtual, 4];
            experienciaPessoa2.Text = listaPessoas[pessoaAtual, 5];
            pontosPessoa2.Text = listaPessoas[pessoaAtual, 6];

            pessoaAtual = (pessoaAtual + 1) % 20;
            nomePessoa1.Text = listaPessoas[pessoaAtual, 0];
            idadePessoa1.Text = listaPessoas[pessoaAtual, 1];
            generoPessoa1.Text = listaPessoas[pessoaAtual, 2];
            habilitacoesPessoa1.Text = listaPessoas[pessoaAtual, 4];
            experienciaPessoa1.Text = listaPessoas[pessoaAtual, 5];
            pontosPessoa1.Text = listaPessoas[pessoaAtual, 6];

        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuJogar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            labelProfissao.Visible = true;
            buttonEscolher.Visible = true;
            pessoaAtual = -1;
            exibirNovoPar();
            
        }

        private void menuItemLerCartoes_Click(object sender, EventArgs e)
        {

        }

        private void menuItemGuardarCartoes_Click(object sender, EventArgs e)
        {

        }

        private void menuItemEliminar_Click(object sender, EventArgs e)
        {

        }

        private void menuItemAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEscolher_Click(object sender, EventArgs e)
        {
            exibirNovoPar();
        }
    }
}
