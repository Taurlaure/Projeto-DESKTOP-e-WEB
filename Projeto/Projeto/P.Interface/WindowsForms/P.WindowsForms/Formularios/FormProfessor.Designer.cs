namespace P.WindowsForms.Formularios
{
    partial class FormProfessor
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
            this.nomeProfessor = new System.Windows.Forms.Label();
            this.btnSalvarProfessor = new System.Windows.Forms.Button();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.dataGridProfessor = new System.Windows.Forms.DataGridView();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeProfessor
            // 
            this.nomeProfessor.AutoSize = true;
            this.nomeProfessor.Location = new System.Drawing.Point(28, 27);
            this.nomeProfessor.Name = "nomeProfessor";
            this.nomeProfessor.Size = new System.Drawing.Size(35, 13);
            this.nomeProfessor.TabIndex = 0;
            this.nomeProfessor.Text = "Nome";
            // 
            // btnSalvarProfessor
            // 
            this.btnSalvarProfessor.Location = new System.Drawing.Point(31, 151);
            this.btnSalvarProfessor.Name = "btnSalvarProfessor";
            this.btnSalvarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProfessor.TabIndex = 2;
            this.btnSalvarProfessor.Text = "Salvar";
            this.btnSalvarProfessor.UseVisualStyleBackColor = true;
            this.btnSalvarProfessor.Click += new System.EventHandler(this.btnSalvarProfessor_Click);
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.Location = new System.Drawing.Point(174, 150);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProfessor.TabIndex = 3;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = true;
            this.btnExcluirProfessor.Click += new System.EventHandler(this.btnExcluirProfessor_Click);
            // 
            // dataGridProfessor
            // 
            this.dataGridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfessor.Location = new System.Drawing.Point(31, 216);
            this.dataGridProfessor.Name = "dataGridProfessor";
            this.dataGridProfessor.Size = new System.Drawing.Size(386, 337);
            this.dataGridProfessor.TabIndex = 5;
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(69, 24);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(203, 21);
            this.comboBoxProfessor.TabIndex = 6;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 630);
            this.Controls.Add(this.comboBoxProfessor);
            this.Controls.Add(this.dataGridProfessor);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Controls.Add(this.btnSalvarProfessor);
            this.Controls.Add(this.nomeProfessor);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
            this.Load += new System.EventHandler(this.FormProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeProfessor;
        private System.Windows.Forms.Button btnSalvarProfessor;
        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.DataGridView dataGridProfessor;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
    }
}