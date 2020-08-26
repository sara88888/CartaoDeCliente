
namespace WindowsFormsApplication1
{
    using System;
    public class CartaoCliente
    {
        #region propriedades

        public int IdCartao { get; set; }
        public string NomeCompleto { get; set; }
        public int NumeroCompra { get; set; }
        public decimal ValTotal { get; set; }
        public int ContaCinq { get; set; }
        public int Pontos { get; set; }
        public decimal TxPrize { get; set; }

        #endregion

        #region construtores

        public CartaoCliente(int a, string b)
        {
            IdCartao= a;
            NomeCompleto = b;
            NumeroCompra = 1;
            ValTotal = 0.0m;
            ContaCinq = 0;
            Pontos = 0;
            TxPrize = 0.1m;
            
        }  //construtor default

        #endregion

        #region métodos
        
        public void Compra (decimal valor)
        {
            NumeroCompra++;
            ValTotal += valor;
            Pontos += Convert.ToInt32(valor * TxPrize);
            //Math.Floor seria utilizado se necessário,mas ao converter para inteiro arredonda sempre para baixo
            int multCinq = Pontos / 50;
            if ( multCinq > ContaCinq)
                Pontos += (multCinq - ContaCinq) * 5;
            ContaCinq = multCinq;
        }

        public void levPremio( int valpontos)
        {
            //só levantam o prémio se os Pontos forem suficientes...
            if (Pontos >=valpontos)
                Pontos -= valpontos;
        }

        public void transfPontos (int cardpts)
        {
            Pontos += cardpts;
        }

        public void mudaTxPrize (decimal novaTx)
        {
            TxPrize = novaTx;
        }
        public void mudarNome(string nome, string apel)
        {
            NomeCompleto = $"{nome} {apel}";
        }

        #endregion
    }
}
