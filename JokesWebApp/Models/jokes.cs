namespace jOKESWEBAPP.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        public string JokePergunta { get; set; }
        public string JokeResposta { get; set; }

        public Jokes()
        {
            Id = 0;
           // JokePergunta = string.Empty;
           // JokeResposta = string.Empty;
        }


    }
}
