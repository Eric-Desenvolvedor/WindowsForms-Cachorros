namespace JPLM_Estudos
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
            txtQntImagem = new TextBox();
            btnEnviar = new Button();
            cardImg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cardImg).BeginInit();
            SuspendLayout();
            // 
            // txtQntImagem
            // 
            txtQntImagem.Location = new Point(336, 12);
            txtQntImagem.Name = "txtQntImagem";
            txtQntImagem.Size = new Size(100, 23);
            txtQntImagem.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(356, 65);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(64, 26);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // cardImg
            // 
            cardImg.AllowUserToAddRows = false;
            cardImg.AllowUserToDeleteRows = false;
            cardImg.AllowUserToOrderColumns = true;
            cardImg.AllowUserToResizeColumns = false;
            cardImg.AllowUserToResizeRows = false;
            cardImg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cardImg.Location = new Point(55, 133);
            cardImg.Name = "cardImg";
            cardImg.ReadOnly = true;
            cardImg.Size = new Size(700, 260);
            cardImg.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cardImg);
            Controls.Add(btnEnviar);
            Controls.Add(txtQntImagem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQntImagem;
        private Button btnEnviar;
        private DataGridView cardImg;
    }
}
