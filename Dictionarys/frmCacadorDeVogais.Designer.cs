namespace Dictionarys
{
    partial class frmCacadorDeVogais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCacadorDeVogais));
            this.lblDigiteUmaFrase = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDigiteUmaFrase
            // 
            this.lblDigiteUmaFrase.AutoSize = true;
            this.lblDigiteUmaFrase.Location = new System.Drawing.Point(256, 119);
            this.lblDigiteUmaFrase.Name = "lblDigiteUmaFrase";
            this.lblDigiteUmaFrase.Size = new System.Drawing.Size(95, 15);
            this.lblDigiteUmaFrase.TabIndex = 0;
            this.lblDigiteUmaFrase.Text = "Digite uma Frase";
            this.lblDigiteUmaFrase.Click += new System.EventHandler(this.lblDigiteUmaFrase_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(266, 183);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 31);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbFrase
            // 
            this.txbFrase.Location = new System.Drawing.Point(176, 137);
            this.txbFrase.Multiline = true;
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(255, 40);
            this.txbFrase.TabIndex = 2;
            this.txbFrase.TextChanged += new System.EventHandler(this.txbFrase_TextChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 21;
            this.lbResultado.Location = new System.Drawing.Point(176, 240);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(255, 130);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.SelectedIndexChanged += new System.EventHandler(this.lbResultado_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("VECTRO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(72, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 54);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CaÇador De\r\nVOGAIS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // frmCacadorDeVogais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblDigiteUmaFrase);
            this.MaximizeBox = false;
            this.Name = "frmCacadorDeVogais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caçador de Vogais";
            this.Load += new System.EventHandler(this.frmCacadorDeVogais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDigiteUmaFrase;
        private Button btnVerificar;
        private TextBox txbFrase;
        private ListBox lbResultado;
        private PictureBox pictureBox1;
        private Label lblTitulo;
    }
}