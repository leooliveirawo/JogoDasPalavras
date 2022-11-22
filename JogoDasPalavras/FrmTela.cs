namespace JogoDasPalavras
{
    public partial class FrmForca : Form
    {
        private Jogo jogo;

        public FrmForca()
        {
            InitializeComponent();

            jogo = new Jogo(5);

        }

        private void FrmForca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (jogo.Status == JogoStatus.Jogando)
            {
                try
                {
                    if (char.IsLetter(e.KeyChar))
                    {
                        jogo.Tentar(e.KeyChar);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
                finally
                {
                    Renderizar();
                }
            }
        }

        private void FrmForca_Load(object sender, EventArgs e)
        {
            jogo.Iniciar();

        }

        private void Renderizar()
        {
            var frase = jogo.ObterFrase();
            var fraseFormatada = "";

            foreach (var letra in frase)
            {
                if (fraseFormatada != "")
                    fraseFormatada += " ";

                fraseFormatada += letra;
            }

            lbFrase.Text = $"Frase:\n{fraseFormatada}";

            lbErros.Text = $"Erros: {jogo.NumeroErros}/{jogo.NumeroMaximoErros}";

            var letrasTentadas = jogo.LetrasTentadas;
            var letrasTentadasfromada = "";

            foreach (var letraTentada in letrasTentadas)
            {
                if (letrasTentadasfromada != "")
                    letrasTentadasfromada += " - ";

                letrasTentadasfromada += letraTentada;
            }

            lbLetrasTentadas.Text = $"Letras tentadas:\n {letrasTentadasfromada}";

            if (jogo.Status == JogoStatus.Perdeu)
            {
                btnDesistir.Visible = false;
                MessageBox.Show(this, "Que pena, você não acertou!");

            }
            else if (jogo.Status == JogoStatus.Ganhou)
            {
                btnDesistir.Visible = false;

                MessageBox.Show(this, "Parabéns, você acertou!");
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            jogo.NovaPartida();

            pnJogo.Visible = true;
            btnDesistir.Visible = true;
            btnIntroducao.Visible = false;

            Renderizar();

        }

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            btnDesistir.Visible = false;
        }
    }
}