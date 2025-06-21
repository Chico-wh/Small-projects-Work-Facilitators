using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculadoraPacotes
{
    public partial class Form1 : Form
    {
        private List<Acomodacao> acomodacoes = new List<Acomodacao>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAcomodacao.Text) ||
                !double.TryParse(txtValor.Text, out double valor) ||
                !int.TryParse(txtPax.Text, out int pax) || pax <= 0)
            {
                MessageBox.Show("Preencha corretamente o nome, valor e número de pessoas (pax) da acomodação.");
                return;
            }

            acomodacoes.Add(new Acomodacao
            {
                Nome = txtAcomodacao.Text,
                Valor = valor,
                Pax = pax
            });

            lstAcomodacoes.Items.Add($"{txtAcomodacao.Text} - R$ {valor:F2} | {pax} pax");

            txtAcomodacao.Clear();
            txtValor.Clear();
            txtPax.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNoites.Text, out int noites) || noites <= 0 ||
                !double.TryParse(txtCambio.Text, out double cambio) || cambio <= 0 ||
                !double.TryParse(txtMarkup.Text, out double markup) || markup <= 0)
            {
                MessageBox.Show("Verifique os campos de noites, câmbio e markup (devem ser maiores que zero).");
                return;
            }

            lstResultados.Items.Clear();

            foreach (var a in acomodacoes)
            {
                double totalBRL = a.Valor * noites;
                double totalUSD = totalBRL / cambio;
                double totalComMarkup = totalUSD / markup; // divide pelo markup conforme solicitado
                double precoPorPessoaUSD = totalComMarkup / a.Pax;

                lstResultados.Items.Add(
                    $"{a.Nome} - Total BRL: R$ {totalBRL:F2} | Total USD (câmbio): {totalUSD:F2} | Com Markup: {totalComMarkup:F2} | Por pax: USD {precoPorPessoaUSD:F2}"
                );
            }
        }
    }

    public class Acomodacao
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Pax { get; set; }
    }
}
