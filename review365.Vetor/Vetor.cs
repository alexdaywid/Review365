namespace review365.Vetor
{
    public class Vetor
    {
        public Vetor(int capacidade)
        {
            this.elementos = new string[capacidade];
        }
        private string[] elementos { get; set; }
    }
}