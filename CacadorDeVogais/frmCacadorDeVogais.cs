using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacadorDeVogais
{
    public partial class frmCacadorDeVogais : Form
    {

        public Dictionary<char, int> VogaisNaFrase { get; set; }
        public frmCacadorDeVogais()
        {
            InitializeComponent();
        }

      

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();

            VogaisNaFrase = new Dictionary<char, int>()
            {
                {'A', 0 },
                {'E', 0 },
                {'I', 0},
                {'O', 0},
                {'U', 0 }
            };

            VogaisNaFrase = atualizaDicionario(removeAcentuacao(txbFrase.Text), VogaisNaFrase);


            apresentaContagemVogais(VogaisNaFrase, lbResultado);
        }
        

        private Dictionary<char, int> atualizaDicionario(string frase, Dictionary<char, int> dicionario)
        {
            foreach (var letra in frase.ToUpper())
            {
                if (dicionario.ContainsKey(letra))
                {
                    dicionario[letra] += 1;
                }
            }

            return dicionario;
        }

        private void apresentaContagemVogais(Dictionary<char, int> dicionario, ListBox listaParaImprimir)
        {

            foreach (KeyValuePair<char, int> linha in dicionario)
            {

                listaParaImprimir.Items.Add($"Contém {linha.Value} letra(s) {linha.Key}");

            }

        }

        private string removeAcentuacao(string text)
        {
            return new string(text.Normalize(NormalizationForm.FormD));
        }

        
    }
}
