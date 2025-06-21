namespace CalculadoraPacotes
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

        private void InitializeComponent()
        {
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.txtNoites = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.txtAcomodacao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstAcomodacoes = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // 
            // txtHotel
            // 
            this.txtHotel.Location = new System.Drawing.Point(12, 25);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(200, 23);
            this.txtHotel.PlaceholderText = "Nome do Hotel";

            // 
            // txtNoites
            // 
            this.txtNoites.Location = new System.Drawing.Point(220, 25);
            this.txtNoites.Name = "txtNoites";
            this.txtNoites.Size = new System.Drawing.Size(60, 23);
            this.txtNoites.PlaceholderText = "Noites";

            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(290, 25);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(60, 23);
            this.txtCambio.PlaceholderText = "Câmbio";

            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(360, 25);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(60, 23);
            this.txtMarkup.PlaceholderText = "Markup %";

            // 
            // txtAcomodacao
            // 
            this.txtAcomodacao.Location = new System.Drawing.Point(12, 65);
            this.txtAcomodacao.Name = "txtAcomodacao";
            this.txtAcomodacao.Size = new System.Drawing.Size(200, 23);
            this.txtAcomodacao.PlaceholderText = "Acomodação";

            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(220, 65);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.PlaceholderText = "Valor (R$)";

            // 
            // txtPax
            // 
            this.txtPax.Location = new System.Drawing.Point(330, 65);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(50, 23);
            this.txtPax.PlaceholderText = "Pax";

            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(385, 65);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // 
            // lstAcomodacoes
            // 
            this.lstAcomodacoes.FormattingEnabled = true;
            this.lstAcomodacoes.ItemHeight = 15;
            this.lstAcomodacoes.Location = new System.Drawing.Point(12, 100);
            this.lstAcomodacoes.Name = "lstAcomodacoes";
            this.lstAcomodacoes.Size = new System.Drawing.Size(448, 94);

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(448, 30);
            this.btnCalcular.Text = "Calcular Pacote";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 15;
            this.lstResultados.Location = new System.Drawing.Point(12, 240);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(600, 109);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(474, 370);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.txtNoites);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.txtAcomodacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lstAcomodacoes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstResultados);
            this.Name = "Form1";
            this.Text = "Calculadora de Pacotes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.TextBox txtNoites;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.TextBox txtAcomodacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lstAcomodacoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstResultados;
    }
}
