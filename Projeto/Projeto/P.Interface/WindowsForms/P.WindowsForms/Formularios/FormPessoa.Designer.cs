namespace P.WindowsForms.Formularios
{
    partial class FormPessoa
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
            this.nomePessoa = new System.Windows.Forms.Label();
            this.textBoxNomePessoa = new System.Windows.Forms.TextBox();
            this.btnExcluirPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.dataGridPessoa = new System.Windows.Forms.DataGridView();
            this.labelEnderecoPessoA = new System.Windows.Forms.Label();
            this.enderecoPessoa = new System.Windows.Forms.TextBox();
            this.numeroPessoa = new System.Windows.Forms.Label();
            this.textNumeroPessoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // nomePessoa
            // 
            this.nomePessoa.AutoSize = true;
            this.nomePessoa.Location = new System.Drawing.Point(51, 43);
            this.nomePessoa.Name = "nomePessoa";
            this.nomePessoa.Size = new System.Drawing.Size(38, 13);
            this.nomePessoa.TabIndex = 0;
            this.nomePessoa.Text = "Nome:";
            // 
            // textBoxNomePessoa
            // 
            this.textBoxNomePessoa.Location = new System.Drawing.Point(95, 40);
            this.textBoxNomePessoa.Name = "textBoxNomePessoa";
            this.textBoxNomePessoa.Size = new System.Drawing.Size(359, 20);
            this.textBoxNomePessoa.TabIndex = 1;
            // 
            // btnExcluirPessoa
            // 
            this.btnExcluirPessoa.Location = new System.Drawing.Point(427, 170);
            this.btnExcluirPessoa.Name = "btnExcluirPessoa";
            this.btnExcluirPessoa.Size = new System.Drawing.Size(105, 28);
            this.btnExcluirPessoa.TabIndex = 10;
            this.btnExcluirPessoa.Text = "Excluir";
            this.btnExcluirPessoa.UseVisualStyleBackColor = true;
            this.btnExcluirPessoa.Click += new System.EventHandler(this.btnExcluirPessoa_Click);
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.Location = new System.Drawing.Point(250, 170);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(105, 28);
            this.btnEditarPessoa.TabIndex = 9;
            this.btnEditarPessoa.Text = "Editar";
            this.btnEditarPessoa.UseVisualStyleBackColor = true;
            this.btnEditarPessoa.Click += new System.EventHandler(this.btnEditarPessoa_Click);
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Location = new System.Drawing.Point(73, 170);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(105, 28);
            this.btnSalvarPessoa.TabIndex = 8;
            this.btnSalvarPessoa.Text = "Salvar";
            this.btnSalvarPessoa.UseVisualStyleBackColor = true;
            this.btnSalvarPessoa.Click += new System.EventHandler(this.btnSalvarPessoa_Click);
            // 
            // dataGridPessoa
            // 
            this.dataGridPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPessoa.Location = new System.Drawing.Point(22, 221);
            this.dataGridPessoa.Name = "dataGridPessoa";
            this.dataGridPessoa.Size = new System.Drawing.Size(488, 293);
            this.dataGridPessoa.TabIndex = 11;
            // 
            // labelEnderecoPessoA
            // 
            this.labelEnderecoPessoA.AutoSize = true;
            this.labelEnderecoPessoA.Location = new System.Drawing.Point(54, 79);
            this.labelEnderecoPessoA.Name = "labelEnderecoPessoA";
            this.labelEnderecoPessoA.Size = new System.Drawing.Size(64, 13);
            this.labelEnderecoPessoA.TabIndex = 12;
            this.labelEnderecoPessoA.Text = "Logradouro:";
            // 
            // enderecoPessoa
            // 
            this.enderecoPessoa.Location = new System.Drawing.Point(124, 76);
            this.enderecoPessoa.Name = "enderecoPessoa";
            this.enderecoPessoa.Size = new System.Drawing.Size(330, 20);
            this.enderecoPessoa.TabIndex = 13;
            // 
            // numeroPessoa
            // 
            this.numeroPessoa.AutoSize = true;
            this.numeroPessoa.Location = new System.Drawing.Point(472, 79);
            this.numeroPessoa.Name = "numeroPessoa";
            this.numeroPessoa.Size = new System.Drawing.Size(20, 13);
            this.numeroPessoa.TabIndex = 14;
            this.numeroPessoa.Text = "nº:";
            // 
            // textNumeroPessoa
            // 
            this.textNumeroPessoa.Location = new System.Drawing.Point(499, 79);
            this.textNumeroPessoa.Name = "textNumeroPessoa";
            this.textNumeroPessoa.Size = new System.Drawing.Size(81, 20);
            this.textNumeroPessoa.TabIndex = 15;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 607);
            this.Controls.Add(this.textNumeroPessoa);
            this.Controls.Add(this.numeroPessoa);
            this.Controls.Add(this.enderecoPessoa);
            this.Controls.Add(this.labelEnderecoPessoA);
            this.Controls.Add(this.dataGridPessoa);
            this.Controls.Add(this.btnExcluirPessoa);
            this.Controls.Add(this.btnEditarPessoa);
            this.Controls.Add(this.btnSalvarPessoa);
            this.Controls.Add(this.textBoxNomePessoa);
            this.Controls.Add(this.nomePessoa);
            this.Name = "FormPessoa";
            this.Text = "FormPessoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomePessoa;
        private System.Windows.Forms.TextBox textBoxNomePessoa;
        private System.Windows.Forms.Button btnExcluirPessoa;
        private System.Windows.Forms.Button btnEditarPessoa;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.DataGridView dataGridPessoa;
        private System.Windows.Forms.Label labelEnderecoPessoA;
        private System.Windows.Forms.TextBox enderecoPessoa;
        private System.Windows.Forms.Label numeroPessoa;
        private System.Windows.Forms.TextBox textNumeroPessoa;
    }
}