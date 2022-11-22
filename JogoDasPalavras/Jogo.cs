namespace JogoDasPalavras
{
    public class Jogo
    {
        private readonly IEnumerable<Frase> frases;
        private readonly int numeroFrases;
        private readonly Random randomizador;

        public JogoStatus Status { get; private set; }

        public int NumeroTentativas { get; private set; }
        public int NumeroMaximoErros { get; private set; }
        public int NumeroErros { get; private set; }

        public string LetrasTentadas { get; private set; }
        public string LetrasAcertadas { get; private set; }
        private string frase;
        private string fraseAcertada;

        public Jogo(int numeroMaximoErros)
        {
            Status = JogoStatus.NaoIniciou;

            NumeroMaximoErros = numeroMaximoErros;

            frases = new Frases();
            numeroFrases = frases.Count();

            randomizador = new Random();
        }

        public void Iniciar()
        {
            if (Status == JogoStatus.Iniciado
                || Status == JogoStatus.Desistiu
                || Status == JogoStatus.Ganhou
                || Status == JogoStatus.Perdeu)
                throw new InvalidOperationException("Você já iniciou o jogo");

            Status = JogoStatus.Iniciado;
        }

        public void NovaPartida()
        {
            if (Status == JogoStatus.NaoIniciou)
                throw new InvalidOperationException("Você não iniciou o jogo");

            Status = JogoStatus.Jogando;

            frase = frases.ElementAt(randomizador.Next(numeroFrases - 1)).Texto;
            fraseAcertada = "";

            foreach (var letra in frase)
            {
                if (letra == ','
                    || letra == ' ')
                    fraseAcertada += letra;
                else
                    fraseAcertada += "_";
            }

            NumeroErros = 0;
            NumeroTentativas = 0;
            LetrasAcertadas = "";
            LetrasTentadas = "";
        }

        public void Tentar(char letraInformada)
        {
            if (Status == JogoStatus.NaoIniciou)
                throw new InvalidOperationException("Você não iniciou o jogo");

            if (Status == JogoStatus.Parou)
                throw new InvalidOperationException("Você não iniciou o jogo");

            if (Status == JogoStatus.Desistiu)
                throw new InvalidOperationException("Você desistiu da partida");

            if (Status == JogoStatus.Ganhou)
                throw new InvalidOperationException("Você ganhou da partida");

            if (Status == JogoStatus.Perdeu)
                throw new InvalidOperationException("Você perdeu a partida");

            if (char.IsLetter(letraInformada))
            {
                letraInformada = Convert.ToChar(letraInformada.ToString().ToUpper());

                if (LetrasTentadas.Contains(letraInformada))
                    throw new InvalidOperationException("Você já tentou essa letra");

                LetrasTentadas += letraInformada;

                if (frase.Contains(letraInformada))
                {
                    LetrasAcertadas += letraInformada;
                    fraseAcertada = "";

                    foreach (var letra in frase)
                    {
                        if (letra == ','
                            || letra == ' ')
                            fraseAcertada += letra;
                        else if (LetrasAcertadas.Any(x => x == letra))
                            fraseAcertada += letra;
                        else
                            fraseAcertada += "_";
                    }

                    if (frase == fraseAcertada)
                        Status = JogoStatus.Ganhou;
                }
                else
                {
                    NumeroErros++;

                    if (NumeroErros == NumeroMaximoErros)
                        Status = JogoStatus.Perdeu;
                }
            }
            else
                throw new InvalidOperationException("Você não informou uma letra");
        }

        public string ObterFrase()
        {
            if (Status == JogoStatus.NaoIniciou)
                throw new InvalidOperationException("Você não iniciou o jogo");

            if (Status == JogoStatus.Parou)
                throw new InvalidOperationException("Você não iniciou o jogo");

            if (Status == JogoStatus.Jogando)
                return fraseAcertada;
            else
                return frase;
        }
    }
}
