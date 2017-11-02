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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.profSelecionar = new System.Windows.Forms.Label();
            this.dataGridDisciplina = new System.Windows.Forms.DataGridView();
            this.btnSalvarDisciplina = new System.Windows.Forms.Button();
            this.btnEditarDisciplina = new System.Windows.Forms.Button();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // profSelecionar
            // 
            this.profSelecionar.AutoSize = true;
            this.profSelecionar.Location = new System.Drawing.Point(58, 78);
            this.profSelecionar.Name = "profSelecionar";
            this.profSelecionar.Size = new System.Drawing.Size(54, 13);
            this.profSelecionar.TabIndex = 3;
            this.profSelecionar.Text = "Professor:";
            // 
            // dataGridDisciplina
            // 
            this.dataGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisciplina.Location = new System.Drawing.Point(61, 186);
            this.dataGridDisciplina.Name = "dataGridDisciplina";
            this.dataGridDisciplina.Size = new System.Drawing.Size(914, 351);
            this.dataGridDisciplina.TabIndex = 4;
            // 
            // btnSalvarDisciplina
            // 
            this.btnSalvarDisciplina.Location = new System.Drawing.Point(64, 139);
            this.btnSalvarDisciplina.Name = "btnSalvarDisciplina";
            this.btnSalvarDisciplina.Size = new System.Drawing.Size(105, 28);
            this.btnSalvarDisciplina.TabIndex = 5;
            this.btnSalvarDisciplina.Text = "Salvar";
            this.btnSalvarDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnEditarDisciplina
            // 
            this.btnEditarDisciplina.Location = new System.Drawing.Point(226, 139);
            this.btnEditarDisciplina.Name = "btnEditarDisciplina";
            this.btnEditarDisciplina.Size = new System.Drawing.Size(105, 28);
            this.btnEditarDisciplina.TabIndex = 6;
            this.btnEditarDisciplina.Text = "Editar";
            this.btnEditarDisciplina.UseVisualStyleBackColor = true;
            // 
            // FormDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 661);
            this.Controls.Add(this.btnEditarDisciplina);
            this.Controls.Add(this.btnSalvarDisciplina);
            this.Controls.Add(this.dataGridDisciplina);
            this.Controls.Add(this.profSelecionar);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label profSelecionar;
        private System.Windows.Forms.DataGridView dataGridDisciplina;
        private System.Windows.Forms.Button btnSalvarDisciplina;
        private System.Windows.Forms.Button btnEditarDisciplina;
    }
}