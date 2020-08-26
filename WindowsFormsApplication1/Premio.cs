namespace WindowsFormsApplication1
{
    public class Premio
    {
        public int IdPremio { get; set; }
        public string Descricao { get; set; }
        public int Rebate { get; set; }

        public Premio(int idpremio, string descricao,int rebate)
        {
            IdPremio = idpremio;
            Descricao = descricao;
            Rebate = rebate;
        }
        public override string ToString()
        {
            return string.Format(IdPremio + "  " + Descricao + "   " + Rebate);
        }
    }
}
