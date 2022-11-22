using System.Collections.ObjectModel;

namespace JogoDasPalavras
{
    public class Frases : Collection<Frase>, IEnumerable<Frase>
    {
        public Frases()
        {
            Add(new Frase()
            {
                Texto = "BEBIDA",
                Dificuldade = Dificuldades.Facil
            });
            Add(new Frase()
            {
                Texto = "PARALELEPIPEDO",
                Dificuldade = Dificuldades.Medio
            });
            Add(new Frase()
            {
                Texto = "AVIAO",
                Dificuldade = Dificuldades.Facil
            });
            Add(new Frase()
            {
                Texto = "GRAND THEFT AUTO",
                Dificuldade = Dificuldades.Dificil
            });
            Add(new Frase()
            {
                Texto = "NOTEBOOK",
                Dificuldade = Dificuldades.Facil
            });
            Add(new Frase()
            {
                Texto = "ESTADOS UNIDOS",
                Dificuldade = Dificuldades.Medio
            });
            Add(new Frase()
            {
                Texto = "CONTINENTE AMERICANO",
                Dificuldade = Dificuldades.Medio
            });
            Add(new Frase()
            {
                Texto = "SONIC",
                Dificuldade = Dificuldades.Facil
            });
            Add(new Frase()
            {
                Texto = "JOGOS VORASES",
                Dificuldade = Dificuldades.Medio
            });
            Add(new Frase()
            {
                Texto = "HARRY POTTER",
                Dificuldade = Dificuldades.Medio
            });
            Add(new Frase()
            {
                Texto = "ALVO DUMBLEDORE",
                Dificuldade = Dificuldades.Dificil
            });
            Add(new Frase()
            {
                Texto = "ANABELLE",
                Dificuldade = Dificuldades.Medio
            });
            Add(new Frase()
            {
                Texto = "BEBIDA",
                Dificuldade = Dificuldades.Facil
            });
        }
    }
}
