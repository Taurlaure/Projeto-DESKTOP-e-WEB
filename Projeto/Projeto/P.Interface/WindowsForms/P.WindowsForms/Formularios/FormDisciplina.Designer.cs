namespace P.WindowsForms.Formularios
{
    partial class FormDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeDisc = new System.Windows.Forms.Label();
            this.textBoxNomeDisciplina = new System.Windows.Forms.TextBox();
            this.dataGridDisciplina = new System.Windows.Forms.DataGridView();
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.btnEditarDisciplina = new System.Windows.Forms.Button();
            this.btnExcluirDisc = new System.Windows.Forms.Button();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.labelprof = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeDisc
            // 
            this.nomeDisc.AutoSize = true;
            this.nomeDisc.Location = new System.Drawing.Point(58, 35);
            this.nomeDisc.Name = "nomeDisc";
            this.nomeDisc.Size = new System.Drawing.Size(38, 13);
            this.nomeDisc.TabIndex = 0;
            this.nomeDisc.Text = "Nome:";
            // 
            // textBoxNomeDisciplina
            // 
            this.textBoxNomeDisciplina.Location = new System.Drawing.Point(102, 32);
            this.textBoxNomeDisciplina.Name = "textBoxNomeDisciplina";
            this.textBoxNomeDisciplina.Size = new System.Drawing.Size(229, 20);
            this.textBoxNomeDisciplina.TabIndex = 1;
            // 
            // dataGridDisciplina
            // 
            this.dataGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisciplina.Location = new System.Drawing.Point(61, 186);
            this.dataGridDisciplina.Name = "dataGridDisciplina";
            this.dataGridDisciplina.Size = new System.Drawing.Size(914, 351);
            this.dataGridDisciplina.TabIndex = 4;
            this.dataGridDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDisciplina_CellContentClick);
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(64, 139);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(105, 28);
            this.btnSalvarDisciplina.TabIndex = 5;
            this.btnSalvarDisciplina.Text = "Salvar";
            this.btnSalvarDisciplina.UseVisualStyleBackColor = true;
            this.btnSalvarDisciplina.Click += new System.EventHandler(this.btnSalvarDisciplina_Click);
            // 
            // btnEditarDisciplina
            // 
            this.btnEditarDisciplina.Location = new System.Drawing.Point(241, 139);
            this.btnEditarDisciplina.Name = "btnEditarDisciplina";
            this.btnEditarDisciplina.Size = new System.Drawing.Size(105, 28);
            this.btnEditarDisciplina.TabIndex = 6;
            this.btnEditarDisciplina.Text = "Editar";
            this.btnEditarDisciplina.UseVisualStyleBackColor = true;
            this.btnEditarDisciplina.Click += new System.EventHandler(this.btnEditarDisciplina_Click);
            // 
            // btnExcluirDisc
            // 
            this.btnExcluirDisc.Location = new System.Drawing.Point(418, 139);
            this.btnExcluirDisc.Name = "btnExcluirDisc";
            this.btnExcluirDisc.Size = new System.Drawing.Size(105, 28);
            this.btnExcluirDisc.TabIndex = 7;
            this.btnExcluirDisc.Text = "Excluir";
            this.btnExcluirDisc.UseVisualStyleBackColor = true;
            this.btnExcluirDisc.Click += new System.EventHandler(this.btnExcluirDisc_Click);
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(102, 87);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(229, 21);
            this.comboBoxProfessor.TabIndex = 8;
            // 
            // labelprof
            // 
            this.labelprof.AutoSize = true;
            this.labelprof.Location = new System.Drawing.Point(45, 90);
            this.labelprof.Name = "labelprof";
            this.labelprof.Size = new System.Drawing.Size(51, 13);
            this.labelprof.TabIndex = 9;
            this.labelprof.Text = "Professor";
            // 
            // FormDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 661);
            this.Controls.Add(this.labelprof);
            this.Controls.Add(this.comboBoxProfessor);
            this.Controls.Add(this.btnExcluirDisc);
            this.Controls.Add(this.btnEditarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.dataGridDisciplina);
            this.Controls.Add(this.textBoxNomeDisciplina);
            this.Controls.Add(this.nomeDisc);
            this.Name = "FormDisciplina";
            this.Text = "FormDisciplina";
            this.Load += new System.EventHandler(this.FormDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeDisc;
        private System.Windows.Forms.TextBox textBoxNomeDisciplina;
        private System.Windows.Forms.DataGridView dataGridDisciplina;
        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.Button btnEditarDisciplina;
        private System.Windows.Forms.Button btnExcluirDisc;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.Label labelprof;
    }
}