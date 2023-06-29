namespace Trabalho.Escola.Natacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtAluno = new TextBox();
            label5 = new Label();
            cmbListaAtletas = new ComboBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btnCadastrar = new Button();
            label15 = new Label();
            txtProfessor = new TextBox();
            label3 = new Label();
            txtHorario = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(397, 29);
            label1.TabIndex = 0;
            label1.Text = "Seja Bem vindo(a) a APAN Goias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 4;
            label4.Text = "Aluno ";
            // 
            // txtAluno
            // 
            txtAluno.Location = new Point(12, 116);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(100, 23);
            txtAluno.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 267);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 6;
            // 
            // cmbListaAtletas
            // 
            cmbListaAtletas.FormattingEnabled = true;
            cmbListaAtletas.Location = new Point(6, 32);
            cmbListaAtletas.Name = "cmbListaAtletas";
            cmbListaAtletas.Size = new Size(170, 33);
            cmbListaAtletas.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbListaAtletas);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(740, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atletas cadastrados ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 249);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(865, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 164);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 17;
            label15.Text = "Professor ";
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(12, 182);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(100, 23);
            txtProfessor.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 234);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 19;
            label3.Text = "label3";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(12, 252);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(100, 23);
            txtHorario.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 450);
            Controls.Add(txtHorario);
            Controls.Add(label3);
            Controls.Add(txtProfessor);
            Controls.Add(label15);
            Controls.Add(btnCadastrar);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(txtAluno);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtAluno;
        private Label label5;
        private ComboBox cmbListaAtletas;
        private GroupBox groupBox1;
        private Label label6;
        private Button btnCadastrar;
        private Label label15;
        private TextBox txtProfessor;
        private Label label3;
        private TextBox txtHorario;
    }
}