namespace demo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.btnsomar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(90, 50);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(136, 20);
            this.txtn1.TabIndex = 1;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(90, 99);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(136, 20);
            this.txtn2.TabIndex = 2;
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(90, 161);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(136, 23);
            this.btnsomar.TabIndex = 3;
            this.btnsomar.Text = "Somar";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2";
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(90, 135);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(136, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 237);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Calculadora Mega Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

