using System.Text;

namespace Dictionarys
{
    public partial class frmCacadorDeVogais : Form
    {

        public Dictionary<char, int> VogaisNaFrase { get; set; } 

       
        public frmCacadorDeVogais()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();

            VogaisNaFrase = new Dictionary<char, int>()
            {
                {'a', 0 },
                {'e', 0 },
                {'i', 0},
                {'o', 0},
                {'u', 0 }
            };

            VogaisNaFrase = atualizaDicionario(removeAcentuacao(txbFrase.Text), VogaisNaFrase);


            apresentaContagemVogais(VogaisNaFrase, lbResultado);

        }

        private Dictionary<char, int> atualizaDicionario(string frase, Dictionary<char, int> dicionario)
        {
            foreach(var letra in frase)
            {
                if(dicionario.ContainsKey(letra))
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

                listaParaImprimir.Items.Add($" {linha.Key} : {linha.Value}");

            }
         
        }

        private string removeAcentuacao(string text)
        {
            return new string(text.Normalize(NormalizationForm.FormD));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDigiteUmaFrase_Click(object sender, EventArgs e)
        {

        }

        private void txbFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCacadorDeVogais_Load(object sender, EventArgs e)
        {

        }
    }
}