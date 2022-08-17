namespace CommandTranslator
{
    partial class frmCommandTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommandTranslator));
            this.txbComando = new System.Windows.Forms.TextBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.lblDigiteUmComando = new System.Windows.Forms.Label();
            this.lbListaDeOperadores = new System.Windows.Forms.ListBox();
            this.lblOperadoresAceitos = new System.Windows.Forms.Label();
            this.lblTraducao = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbComando
            // 
            this.txbComando.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbComando.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbComando.Location = new System.Drawing.Point(12, 274);
            this.txbComando.Multiline = true;
            this.txbComando.Name = "txbComando";
            this.txbComando.Size = new System.Drawing.Size(255, 64);
            this.txbComando.TabIndex = 11;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraduzir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraduzir.Location = new System.Drawing.Point(273, 274);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(83, 64);
            this.btnTraduzir.TabIndex = 10;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // lblDigiteUmComando
            // 
            this.lblDigiteUmComando.AutoSize = true;
            this.lblDigiteUmComando.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDigiteUmComando.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDigiteUmComando.Location = new System.Drawing.Point(12, 251);
            this.lblDigiteUmComando.Name = "lblDigiteUmComando";
            this.lblDigiteUmComando.Size = new System.Drawing.Size(154, 21);
            this.lblDigiteUmComando.TabIndex = 9;
            this.lblDigiteUmComando.Text = "Digite um comando";
            // 
            // lbListaDeOperadores
            // 
            this.lbListaDeOperadores.FormattingEnabled = true;
            this.lbListaDeOperadores.ItemHeight = 15;
            this.lbListaDeOperadores.Location = new System.Drawing.Point(12, 122);
            this.lbListaDeOperadores.Name = "lbListaDeOperadores";
            this.lbListaDeOperadores.Size = new System.Drawing.Size(344, 124);
            this.lbListaDeOperadores.TabIndex = 12;
            // 
            // lblOperadoresAceitos
            // 
            this.lblOperadoresAceitos.AutoSize = true;
            this.lblOperadoresAceitos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperadoresAceitos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOperadoresAceitos.Location = new System.Drawing.Point(12, 98);
            this.lblOperadoresAceitos.Name = "lblOperadoresAceitos";
            this.lblOperadoresAceitos.Size = new System.Drawing.Size(156, 21);
            this.lblOperadoresAceitos.TabIndex = 13;
            this.lblOperadoresAceitos.Text = "Operadores Aceitos";
            // 
            // lblTraducao
            // 
            this.lblTraducao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTraducao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTraducao.Location = new System.Drawing.Point(12, 352);
            this.lblTraducao.Name = "lblTraducao";
            this.lblTraducao.Size = new System.Drawing.Size(567, 126);
            this.lblTraducao.TabIndex = 14;
            this.lblTraducao.Text = "label1";
            this.lblTraducao.Visible = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(4, 9);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(69, 52);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 15;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Big John", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(70, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 48);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Command \r\nTranslator";
            // 
            // frmCommandTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 502);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblTraducao);
            this.Controls.Add(this.lblOperadoresAceitos);
            this.Controls.Add(this.lbListaDeOperadores);
            this.Controls.Add(this.txbComando);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.lblDigiteUmComando);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmCommandTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Translator";
            this.Load += new System.EventHandler(this.frmCommandTranslator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbComando;
        private Button btnTraduzir;
        private Label lblDigiteUmComando;
        private ListBox lbListaDeOperadores;
        private Label lblOperadoresAceitos;
        private Label lblTraducao;
        private PictureBox pctLogo;
        private Label lblTitulo;
    }
}