namespace WindowsFormsExemplos
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelQuantidadeHoras = new System.Windows.Forms.Label();
            this.textBoxQuantidadeHoras = new System.Windows.Forms.TextBox();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.textBoxValorHora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(50, 35);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(177, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(137, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelQuantidadeHoras
            // 
            this.labelQuantidadeHoras.AutoSize = true;
            this.labelQuantidadeHoras.Location = new System.Drawing.Point(52, 65);
            this.labelQuantidadeHoras.Name = "labelQuantidadeHoras";
            this.labelQuantidadeHoras.Size = new System.Drawing.Size(119, 15);
            this.labelQuantidadeHoras.TabIndex = 2;
            this.labelQuantidadeHoras.Text = "Quantidade de Horas";
            // 
            // textBoxQuantidadeHoras
            // 
            this.textBoxQuantidadeHoras.Location = new System.Drawing.Point(177, 61);
            this.textBoxQuantidadeHoras.Name = "textBoxQuantidadeHoras";
            this.textBoxQuantidadeHoras.Size = new System.Drawing.Size(137, 23);
            this.textBoxQuantidadeHoras.TabIndex = 3;
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Location = new System.Drawing.Point(52, 96);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(62, 15);
            this.labelValorHora.TabIndex = 4;
            this.labelValorHora.Text = "Valor Hora";
            // 
            // textBoxValorHora
            // 
            this.textBoxValorHora.Location = new System.Drawing.Point(177, 90);
            this.textBoxValorHora.Name = "textBoxValorHora";
            this.textBoxValorHora.Size = new System.Drawing.Size(137, 23);
            this.textBoxValorHora.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 188);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxValorHora);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.textBoxQuantidadeHoras);
            this.Controls.Add(this.labelQuantidadeHoras);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelQuantidadeHoras;
        private TextBox textBoxQuantidadeHoras;
        private Label labelValorHora;
        private TextBox textBoxValorHora;
        private Button button1;
    }
}