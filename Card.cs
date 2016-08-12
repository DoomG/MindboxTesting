namespace MindoxTesting
{
    public class Card
    {
        public string Source { get; set; }

        public string Destination { get; set; }

        public override string ToString()
        {
            return Source + "->" + Destination;
        }
    }
}