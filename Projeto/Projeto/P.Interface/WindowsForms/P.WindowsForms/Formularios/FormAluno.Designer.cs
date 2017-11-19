namespace P.WindowsForms.Formularios
{
    partial class FormAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAluno = new System.Windows.Forms.ComboBox();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // comboBoxAluno
            // 
            this.comboBoxAluno.FormattingEnabled = true;
            this.comboBoxAluno.Location = new System.Drawing.Point(67, 36);
            this.comboBoxAluno.Name = "comboBoxAluno";
            this.comboBoxAluno.Size = new System.Drawing.Size(191, 21);
            this.comboBoxAluno.TabIndex = 1;
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.Location = new System.Drawing.Point(29, 98);
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAluno.TabIndex = 2;
            this.btnSalvarAluno.Text = "Salvar";
            this.btnSalvarAluno.UseVisualStyleBackColor = true;
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click_1);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(228, 97);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 3;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click_1);
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Location = new System.Drawing.Point(29, 198);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.Size = new System.Drawing.Size(398, 267);
            this.dataGridViewAluno.TabIndex = 4;
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 540);
            this.Controls.Add(this.dataGridViewAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnSalvarAluno);
            this.Controls.Add(this.comboBoxAluno);
            this.Controls.Add(this.label1);
            this.Name = "FormAluno";
            this.Text = "FormAluno";
            this.Load += new System.EventHandler(this.FormAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAluno;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
    }
}