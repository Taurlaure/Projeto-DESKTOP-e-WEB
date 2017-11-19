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
    

    public partial class FormProfessor : Form
    {
        faculdadeEntities db = new faculdadeEntities();
        private Professor professor;
        public FormProfessor()
        {
            InitializeComponent();
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            comboBoxProfessor.DataSource = db.Pessoa.ToList();
            comboBoxProfessor.DisplayMember = "nome";
            comboBoxProfessor.ValueMember = "IdPessoa";

            dataGridProfessor.ColumnCount = 2;
            dataGridProfessor.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridProfessor.MultiSelect = false;
            dataGridProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridProfessor.Columns[0].HeaderText = "Código";
            dataGridProfessor.Columns[0].DataPropertyName = "IdPessoaProfessor";
            dataGridProfessor.Columns[0].Name = "IdPessoaProfessor";
            dataGridProfessor.Columns[0].Width = 50;

            dataGridProfessor.Columns[1].HeaderText = "Nome";
            dataGridProfessor.Columns[1].DataPropertyName = "nome";
            dataGridProfessor.Columns[1].Name = "nome";
            dataGridProfessor.Columns[1].Width = 150;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var professores = from professor in db.Professor
                              join pessoa in db.Pessoa
                              on professor.idPessoaProfessor equals pessoa.idPessoa
                              select (new { professor.idPessoaProfessor, pessoa.nome });
            dataGridProfessor.DataSource = professores.ToList();

        }

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            if (professor == null)
                professor = new Professor();

            int IdPessoaProfessor = professor.idPessoaProfessor > 0 ? professor.idPessoaProfessor : 0;

            professor.idPessoaProfessor = (int)comboBoxProfessor.SelectedValue;

            string mensagem = "";

            
                db.Professor.Add(professor);
                mensagem = "Professor cadastrado com sucesso!";
            
            db.SaveChanges();
            MessageBox.Show(mensagem);
            CarregarGrid();
            limparCampos();
            
        }
        private void limparCampos()
        {
            comboBoxProfessor.SelectedValue = 0;
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Deseja realmente excluir?", "Confirmar excluisão" 
                , MessageBoxButtons.YesNo) == DialogResult.Yes)            if (dataGridProfessor.SelectedRows.Count > 0)
            {
                    int IdPessoaProfessor = (int)dataGridProfessor.CurrentRow.Cells[0].Value;
                    professor = db.Professor.Where(x => x.idPessoaProfessor == IdPessoaProfessor).FirstOrDefault();

                    db.Professor.Remove(professor);
                    db.SaveChanges();

                    MessageBox.Show("Professor excluído com sucesso!");
                    CarregarGrid();
            }
        }
    }
}
