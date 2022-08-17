namespace CacadorDeVogais
{
    partial class frmCacadorDeVogais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCacadorDeVogais));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblDigiteUmaFrase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("VECTRO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(71, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 54);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "CaÇador De\r\nVOGAIS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;

            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 21;
            this.lbResultado.Location = new System.Drawing.Point(169, 221);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(255, 130);
            this.lbResultado.TabIndex = 9;
            // 
            // txbFrase
            // 
            this.txbFrase.Location = new System.Drawing.Point(169, 118);
            this.txbFrase.Multiline = true;
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(255, 40);
            this.txbFrase.TabIndex = 8;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(259, 164);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 31);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click_1);
            // 
            // lblDigiteUmaFrase
            // 
            this.lblDigiteUmaFrase.AutoSize = true;
            this.lblDigiteUmaFrase.Location = new System.Drawing.Point(249, 100);
            this.lblDigiteUmaFrase.Name = "lblDigiteUmaFrase";
            this.lblDigiteUmaFrase.Size = new System.Drawing.Size(95, 15);
            this.lblDigiteUmaFrase.TabIndex = 6;
            this.lblDigiteUmaFrase.Text = "Digite uma Frase";
            // 
            // frmCacadorDeVogais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblDigiteUmaFrase);
            this.MaximizeBox = false;
            this.Name = "frmCacadorDeVogais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCacadorDeVogais";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private ListBox lbResultado;
        private TextBox txbFrase;
        private Button btnVerificar;
        private Label lblDigiteUmaFrase;
    }
}