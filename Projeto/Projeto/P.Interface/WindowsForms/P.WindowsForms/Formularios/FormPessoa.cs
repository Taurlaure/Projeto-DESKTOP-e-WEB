using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P.Modelo;
using System.Data.Entity;

namespace P.WindowsForms.Formularios
{
    
    public partial class FormPessoa : Form
    {
        faculdadeEntities db = new faculdadeEntities();
        private Pessoa pessoa;

        public FormPessoa()
        {
            InitializeComponent();
        }

  
        private void FormPessoa_Load(object sender, EventArgs e)
        {
            dataGridPessoa.ColumnCount = 2;
            dataGridPessoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridPessoa.MultiSelect = false;
            dataGridPessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridPessoa.Columns[0].HeaderText = "Cód Pessoa";
            dataGridPessoa.Columns[0].DataPropertyName = "idPessoa";
            dataGridPessoa.Columns[0].Width = 150;
            dataGridPessoa.Columns[0].Name = "idPessoa";


            dataGridPessoa.Columns[1].HeaderText = "Nome";
            dataGridPessoa.Columns[1].DataPropertyName = "nome";
            dataGridPessoa.Columns[1].Width = 150;
            dataGridPessoa.Columns[1].Name = "nome";

            dataGridPessoa.Columns[2].HeaderText = "Endereço";
            dataGridPessoa.Columns[2].DataPropertyName = "endereco";
            dataGridPessoa.Columns[2].Width = 150;
            dataGridPessoa.Columns[2].Name = "endereco";

            dataGridPessoa.Columns[3].HeaderText = "Número";
            dataGridPessoa.Columns[3].DataPropertyName = "numero";
            dataGridPessoa.Columns[3].Width = 150;
            dataGridPessoa.Columns[3].Name = "numero";

            carregarGrid();
        }


        public void carregarGrid()
        {
            var pessoas = from pessoa in db.Pessoa
                          select (new
                          {
                              pessoa.idPessoa,
                              pessoa.nome,
                              pessoa.endereco,
                              pessoa.numero

                          });


            dataGridPessoa.DataSource = pessoas.ToList();
        }

        public void limparCampos()
        {
            textBoxNomePessoa.Clear();
            pessoa = null;

        }
        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            if (pessoa == null)
                pessoa = new Pessoa();

            int IdPessoa = pessoa.idPessoa > 0 ? pessoa.idPessoa : 0;

            pessoa.idPessoa = IdPessoa;
            pessoa.nome = textBoxNomePessoa.Text;
            pessoa.endereco = enderecoPessoa.Text;
            pessoa.numero = textNumeroPessoa.Text;

            string mensagem = "";

            if (pessoa.idPessoa == 0)
            {
                db.Pessoa.Add(pessoa);
                mensagem = "Pessoa cadastrada com sucesso!!";
            }
            else
            {
                var obj = db.Entry(pessoa);
                obj.Property(x => x.nome).IsModified = true;
                obj.Property(y => y.endereco).IsModified = true;
                obj.Property(z => z.numero).IsModified = true;

                mensagem = "Pessoa alterada com sucesso!!";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            carregarGrid();
            limparCampos();
        }
         private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            if (dataGridPessoa.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridPessoa.SelectedRows[0];
                int IdPessoa = (int)linha.Cells["idPessoa"].Value;

                pessoa = db.Pessoa.Where(x => x.idPessoa == IdPessoa).FirstOrDefault();
                textBoxNomePessoa.Text = pessoa.nome;
            }

            else
            {
                MessageBox.Show("Selecione uma pessoa!");
            }
        }

        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {
            if (dataGridPessoa.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridPessoa.SelectedRows[0];
                int IdPessoa = (int)linha.Cells["idPessoa"].Value;

                pessoa = db.Pessoa.Where(x => x.idPessoa == IdPessoa).FirstOrDefault();

                db.Pessoa.Remove(pessoa);
                db.SaveChanges();

                MessageBox.Show("Pessoa excluída com sucesso!");
                carregarGrid();
                limparCampos();
            }

            else
            {
                MessageBox.Show("Selecione uma Pessoa para ser excluída");
            }
        }


    }
}
