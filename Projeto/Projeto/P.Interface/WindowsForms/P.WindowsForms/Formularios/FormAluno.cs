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

namespace P.WindowsForms.Formularios
{
    public partial class FormAluno : Form
    {
        faculdadeEntities db = new faculdadeEntities();
        private Aluno aluno;
        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
        
            comboBoxAluno.DataSource = db.Pessoa.ToList();
            comboBoxAluno.DisplayMember = "nome";
            comboBoxAluno.ValueMember = "IdPessoa";

            dataGridViewAluno.ColumnCount = 2;
            dataGridViewAluno.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAluno.MultiSelect = false;
            dataGridViewAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewAluno.Columns[0].HeaderText = "Código";
            dataGridViewAluno.Columns[0].DataPropertyName = "IdPessoaAluno";
            dataGridViewAluno.Columns[0].Name = "IdPessoaAluno";
            dataGridViewAluno.Columns[0].Width = 50;

            dataGridViewAluno.Columns[1].HeaderText = "Nome Aluno";
            dataGridViewAluno.Columns[1].DataPropertyName = "nome";
            dataGridViewAluno.Columns[1].Name = "nome";
            dataGridViewAluno.Columns[1].Width = 150;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var alunos = from aluno in db.Aluno
                              join pessoa in db.Pessoa
                              on aluno.idPessoaAluno equals pessoa.idPessoa
                              select (new { aluno.idPessoaAluno, pessoa.nome });

            dataGridViewAluno.DataSource = alunos.ToList();

        }

        private void limparCampos()
        {
            comboBoxAluno.SelectedValue = 0;
        }

        private void btnSalvarAluno_Click_1(object sender, EventArgs e)
        {
            if (aluno == null)
                aluno = new Aluno();

            int IdPessoaAluno = aluno.idPessoaAluno > 0 ? aluno.idPessoaAluno : 0;

            aluno.idPessoaAluno = (int)comboBoxAluno.SelectedValue;

            string mensagem = "";


            db.Aluno.Add(aluno);
            mensagem = "Aluno cadastrado com sucesso!";

            db.SaveChanges();
            MessageBox.Show(mensagem);
            CarregarGrid();
            limparCampos();
        }

        private void btnExcluirAluno_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Confirmar excluisão"
                , MessageBoxButtons.YesNo) == DialogResult.Yes) if (dataGridViewAluno.SelectedRows.Count > 0)
                {
                    int IdPessoaAluno = (int)dataGridViewAluno.CurrentRow.Cells[0].Value;
                    aluno = db.Aluno.Where(x => x.idPessoaAluno == IdPessoaAluno).FirstOrDefault();

                    db.Aluno.Remove(aluno);
                    db.SaveChanges();

                    MessageBox.Show("Aluno excluído com sucesso!");
                    CarregarGrid();
                }
        }
    }
}
    

