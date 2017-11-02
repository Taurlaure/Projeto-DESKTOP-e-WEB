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
    public partial class FormDisciplina : Form
    {
        faculdadeEntities db = new faculdadeEntities();
        private Disciplina disciplina;

        public FormDisciplina()
        {
            InitializeComponent();
        }

        private void FormDisciplina_Load(object sender, EventArgs e)
        {
            dataGridDisciplina.ColumnCount = 3;
            dataGridDisciplina.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridDisciplina.MultiSelect = false;
            dataGridDisciplina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridDisciplina.Columns[0].HeaderText = "Cód Disciplina";
            dataGridDisciplina.Columns[0].DataPropertyName = "idDisciplina";
            dataGridDisciplina.Columns[0].Width = 150;
            dataGridDisciplina.Columns[0].Name = "idDisciplina";


            dataGridDisciplina.Columns[1].HeaderText = "Disciplina";
            dataGridDisciplina.Columns[1].DataPropertyName = "Descricao";
            dataGridDisciplina.Columns[1].Width = 150;
            dataGridDisciplina.Columns[1].Name = "Descricao";

            dataGridDisciplina.Columns[2].HeaderText = "Professor";
            dataGridDisciplina.Columns[2].DataPropertyName = "Professor";
            dataGridDisciplina.Columns[2].Width = 150;
            dataGridDisciplina.Columns[2].Name = "Professor";

            carregarGrid();
        }

        public void carregarGrid()
        {
            var disciplinas = from disciplina in db.Disciplina
                              select (new
                              {
                                  disciplina.idDisciplina,
                                  disciplina.descricao,
                                  disciplina.Professor
                              });


            dataGridDisciplina.DataSource = disciplinas.ToList();
        }

        private void btnSalvarDisciplina_Click(object sender, EventArgs e)
        {
            if (disciplina == null)
                disciplina = new Disciplina();

            int IdDisciplina = disciplina.idDisciplina > 0 ? disciplina.idDisciplina : 0;

            disciplina.idDisciplina = IdDisciplina;
            disciplina.descricao = textBoxNomeDisciplina.Text;

            string mensagem = "";

            if (disciplina.idDisciplina == 0)
            {
                db.Disciplina.Add(disciplina);
                mensagem = "Disciplina cadastrada com sucesso!!";
            }

            else
            {
                var obj = db.Entry(disciplina);
                obj.Property(x => x.descricao).IsModified = true;

                mensagem = "Disciplina alterada com sucesso!!";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            carregarGrid();
            limparCampos();
        }

        public void limparCampos() {
            textBoxNomeDisciplina.Clear();
            disciplina = null;

        }

        private void btnEditarDisciplina_Click(object sender, EventArgs e)
        {
            if (dataGridDisciplina.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridDisciplina.SelectedRows[0];
                int IdDisciplina = (int)linha.Cells["idDisciplina"].Value;

                disciplina = db.Disciplina.Where(x => x.idDisciplina == IdDisciplina).FirstOrDefault();
                textBoxNomeDisciplina.Text = disciplina.descricao;
            }

            else
            {
                MessageBox.Show("Selecione um disciplina!");
            }

        }
    private void dataGridDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

        private void btnExcluirDisc_Click(object sender, EventArgs e)
        {
            if (dataGridDisciplina.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridDisciplina.SelectedRows[0];
                int IdDisciplina = (int)linha.Cells["idDisciplina"].Value;

                disciplina = db.Disciplina.Where(x => x.idDisciplina == IdDisciplina).FirstOrDefault();

                db.Disciplina.Remove(disciplina);
                db.SaveChanges();

                MessageBox.Show("Disciplina excluída com sucesso!");
                carregarGrid();
                limparCampos();
            }

            else
            {
                MessageBox.Show("Selecione uma disciplina para ser excluída");
            }
        }
    }
   
}

