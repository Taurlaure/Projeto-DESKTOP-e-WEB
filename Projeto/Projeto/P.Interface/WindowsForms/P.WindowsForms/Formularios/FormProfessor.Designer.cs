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
            this.nomeProf = new System.Windows.Forms.Label();
            this.NomeProfBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomeProf
            // 
            this.nomeProf.AutoSize = true;
            this.nomeProf.Location = new System.Drawing.Point(18, 53);
            this.nomeProf.Name = "nomeProf";
            this.nomeProf.Size = new System.Drawing.Size(38, 13);
            this.nomeProf.TabIndex = 0;
            this.nomeProf.Text = "Nome:";
            // 
            // NomeProfBox
            // 
            this.NomeProfBox.Location = new System.Drawing.Point(53, 50);
            this.NomeProfBox.Name = "NomeProfBox";
            this.NomeProfBox.Size = new System.Drawing.Size(234, 20);
            this.NomeProfBox.TabIndex = 1;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 478);
            this.Controls.Add(this.NomeProfBox);
            this.Controls.Add(this.nomeProf);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeProf;
        private System.Windows.Forms.TextBox NomeProfBox;
    }
}