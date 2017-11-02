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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.MdiParent = this;
            formProfessor.Show();        
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisciplina formDisciplina = new FormDisciplina();
            formDisciplina.MdiParent = this;
            formDisciplina.Show();
        }
    }
}
