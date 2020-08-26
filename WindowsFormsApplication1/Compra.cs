namespace WindowsFormsApplication1
{
    public class Compra
    {
        public string Artigo { get; set; }
        public int Qtt { get; set; }
        public decimal Preco { get; set; }

        public Compra(string artigo, int qtt, decimal preco)
        {
            Artigo = artigo;
            Qtt = qtt;
            Preco = preco;
        }
        public override string ToString()
        {
            return string.Format(Artigo+"  "+ Qtt+"   "+ Preco);
        }
    }
}
