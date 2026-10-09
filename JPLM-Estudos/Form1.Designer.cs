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
            txtQTD = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txt = new Label();
            qtdText = new Label();
            ((System.ComponentModel.ISupportInitialize)cardImg).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQntImagem
            // 
            txtQntImagem.Location = new Point(3, 3);
            txtQntImagem.Name = "txtQntImagem";
            txtQntImagem.Size = new Size(123, 23);
            txtQntImagem.TabIndex = 0;
            txtQntImagem.Click += txtQntImagem_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(132, 3);
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
            cardImg.MultiSelect = false;
            cardImg.Name = "cardImg";
            cardImg.ReadOnly = true;
            cardImg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cardImg.Size = new Size(700, 260);
            cardImg.TabIndex = 3;
            // 
            // txtQTD
            // 
            txtQTD.AutoSize = true;
            txtQTD.Location = new Point(368, 94);
            txtQTD.Name = "txtQTD";
            txtQTD.Size = new Size(0, 15);
            txtQTD.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5F));
            tableLayoutPanel1.Controls.Add(txt, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEnviar, 1, 0);
            tableLayoutPanel1.Controls.Add(txtQntImagem, 0, 0);
            tableLayoutPanel1.Controls.Add(qtdText, 1, 1);
            tableLayoutPanel1.Location = new Point(298, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 68);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(3, 34);
            txt.Name = "txt";
            txt.Size = new Size(88, 30);
            txt.TabIndex = 7;
            txt.Text = "Quantidade de Imagens:";
            // 
            // qtdText
            // 
            qtdText.AutoSize = true;
            qtdText.Location = new Point(132, 34);
            qtdText.Name = "qtdText";
            qtdText.Size = new Size(13, 15);
            qtdText.TabIndex = 8;
            qtdText.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtQTD);
            Controls.Add(cardImg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardImg).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQntImagem;
        private Button btnEnviar;
        private DataGridView cardImg;
        private Label txtQTD;
        private TableLayoutPanel tableLayoutPanel1;
        private Label txt;
        private Label qtdText;
    }
}
