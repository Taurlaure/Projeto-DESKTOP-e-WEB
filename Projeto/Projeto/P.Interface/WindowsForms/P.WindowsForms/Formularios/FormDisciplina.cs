using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.WindowsForms.Formularios
{
    public partial class FormDisciplina : Form
    {
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
        }

    }
}
