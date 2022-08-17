namespace CommandTranslator
{
    public partial class frmCommandTranslator : Form
    {

        Dictionary<string, string> Comandos = new Dictionary<string, string>()
            {
                {"if"," se "},
                {"while", " enquanto "},
                {">"," maior que "},
                {"<"," menor que "},
                {">="," maior ou igual a "},
                {"<="," menor ou igual a "},
                {"=="," igual a "},
                {"!="," diferente de "},
            };
        public frmCommandTranslator()
        {
            InitializeComponent();
        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            lblTraducao.Visible = true;

            List<string> palavrasDaFrase = new List<string>();

            palavrasDaFrase = quebraFraseEmPalavras(txbComando.Text);

            lblTraducao.Text = traduzFrase(palavrasDaFrase, Comandos);
        }

        private void frmCommandTranslator_Load(object sender, EventArgs e)
        {
            insereComandosAceitos(lbListaDeOperadores, "if");
            insereComandosAceitos(lbListaDeOperadores, "while");
            insereComandosAceitos(lbListaDeOperadores, ">");
            insereComandosAceitos(lbListaDeOperadores, "<");
            insereComandosAceitos(lbListaDeOperadores, ">=");
            insereComandosAceitos(lbListaDeOperadores, "<=");
            insereComandosAceitos(lbListaDeOperadores, "==");
            insereComandosAceitos(lbListaDeOperadores, "!=");
        }


        private ListBox insereComandosAceitos(ListBox lista,string comando)
        {
            lista.Items.Add(comando);

            return lista;
        }

        private string traduzFrase(List<string> listaPalavras, Dictionary<string,string> dicionario)
        {
            string traducao = "";

           foreach(string palavra in listaPalavras)
            {
                if (dicionario.ContainsKey(palavra))
                {
                    traducao += dicionario[palavra];
                }
                else
                {
                    traducao += palavra;
                }
            }

            return traducao;
        }

        private List<string> quebraFraseEmPalavras(string frase)
        {
            string palavra = "";
            int tamanhoFraseOriginal = frase.Length;
            bool fimDaAnalise = false;

            List<string> lista = new List<string>();


            for (int i = 0; i < tamanhoFraseOriginal; i++)
            {
                if (i == 0 && frase[i].ToString() == " ")
                {
                    frase.Remove(i);
                }

                if(i == tamanhoFraseOriginal-1)
                {
                    palavra += frase[i];
                    fimDaAnalise = true;
                }

                if (frase[i].ToString() != " " && fimDaAnalise == false)
                {
                    palavra += frase[i];
                    
                }
                else

                {
                    if(!String.IsNullOrWhiteSpace(palavra))
                    {
                        lista.Add(palavra);
                    }
                    
                    palavra = "";
                }
            }

            return lista;
        }
    }
}