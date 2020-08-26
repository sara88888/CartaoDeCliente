namespace WindowsFormsApplication1
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        /// <summary>
        /// declara um novo objeto da classe CartaoCliente
        /// </summary>
        private CartaoCliente meuCartao;
        private CartaoCliente[] cartoes;
        private Compra[] compras;
        private Premio[] premios;
        private decimal parcela = 0.00m, valor = 0.00m, taxnew = 0.00m;
        private int id=0, ptsRebate = 0, ptsCard = 0, contador1=0, contador2=0;
        private string namenew = string.Empty, apelnew = string.Empty;
      
        public Form1()
        {
            InitializeComponent();
            meuCartao = new CartaoCliente(1,string.Empty);
            compras = new Compra[5];
            premios = new Premio[3];
            cartoes = new CartaoCliente[2];
            abreLoja();
        }

        private void abreLoja()
        {
            compras[0] = new Compra("Mini-meias", 1, 3.50m);
            compras[1] = new Compra("Collant lycra", 1, 6.25m);
            compras[2] = new Compra("Collant caxemira", 1, 30.00m);
            compras[3] = new Compra("Pijama caxemira e seda", 1, 82.30m);
            compras[4] = new Compra("Roupão seda", 1, 160.40m);
            premios[0] = new Premio(1,"Luvas algodao", 10);
            premios[1] = new Premio(2,"Luvas caxemira", 20);
            premios[2] = new Premio(3,"Luvas seda", 30);
            cartoes[0] = new CartaoCliente(1,"Adelina Silva");
            cartoes[1] = new CartaoCliente(2, "Mariana Fagundes");
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            tbIDcartao.Enabled = true;
            tbIDcartao.Text = "";
            lblNome.Enabled = true;
            btnGravar.Visible = true;
            //a loja fica visível
            groupBox3.Visible = true;
            //tbNrCompra.Enabled = true;
            //cbCompra.Enabled = true;
            //udTotalCompra.Enabled = true;
            //cbRebate.Enabled = true;

            //o escritório é ocultado
            groupBox2.Visible = false;
            //label3.Visible = false;
            //label5.Visible = false;
            //label12.Visible = false;
            //label13.Visible = false;
            //label9.Visible = false;
            //lbl3.Visible = false;
            //tbTransf.Visible = false;
            //tbPrimeiroNome.Visible = false;
            //tbApelido.Visible = false;
            //tbValTotal.Visible = false;
            //udTxPrize.Visible = false;

            //ainda não se gravou as operações de loja
            btnEscritorio.Enabled = false;
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            tbIDcartao.Enabled = true;
            tbIDcartao.Text = "";
            lblNome.Enabled = true;
            btnGravar.Visible = true;
            //o escritório fica visível
            groupBox2.Visible = true;

            //label3.Visible = true;
            //label5.Visible = true;
            //label12.Visible = true;
            //label13.Visible = true;
            //label9.Visible = true;
            //lbl3.Visible = true;
            //tbTransf.Visible = true;
            //tbPrimeiroNome.Visible = true;
            //tbApelido.Visible = true;
            //tbValTotal.Visible = true;
            //udTxPrize.Visible = true;

            //a loja é ocultada
            groupBox3.Visible = false;

            //tbNrCompra.Visible = false;
            //cbCompra.Visible = false;
            //udTotalCompra.Visible = false;
            //cbRebate.Visible = false;

            //ainda não se concluiu as operações de escritório
            btnLoja.Enabled = false;
        }

        //não deixa escrever letras na textBox
        private void tbIDcartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                e.Handled = true;
        }

        //o lojista insere o nr. do cartão
        private void tbIDcartao_TextChanged(object sender, EventArgs e)
        {
            //if(!int.TryParse(tbIDcartao.Text, out id))
            //{
            //    MessageBox.Show("Introduza o número do cartão");
            //    return;
            //}   usando a tecla backspace e de novo um nº n assume como nº

            int.TryParse(tbIDcartao.Text, out id);
            lblNome.Text = achaCliente(id);
            if (lblNome.Text == "")
            {
                return;
            }
            //ainda n se concluiu as operações com este cartão
            tbIDcartao.Enabled = false;
            tbNrCompra.Text = meuCartao.NumeroCompra.ToString();
            tbPontos.Text = meuCartao.Pontos.ToString();
            //atribuição de datasource
            cbCompra.DataSource = compras;
            cbCompra.DisplayMember = compras.ToString();
            //a não ser q se limpe as combos, só à 1ª passagem pela atribuição da datasource é q o selectedindex da combo é alterado
            cbRebate.DataSource = premios;
            cbRebate.DisplayMember = premios.ToString();

            tbValTotal.Text = meuCartao.ValTotal.ToString();
            udTxPrize.Value = meuCartao.TxPrize;
        }

        private string achaCliente (int id)
        {
            for (int j = 0; j < cartoes.Length; j++)
                if (cartoes[j].IdCartao == id)
                {
                    meuCartao=cartoes[j];
                    return cartoes[j].NomeCompleto;
                }
            return null;
        }

        //faz as compras
        private void cbCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contador1 == 0)
            {   //isto foi a 1ª passagem pela atriuição de datasource
                tbArtigo.Text = "";
                tbQtt.Text = "";
                tbPreco.Text = "";
            }
            else
            {   //isto já foi uma compra
                tbArtigo.Text += compras[cbCompra.SelectedIndex].Artigo+Environment.NewLine;
                tbQtt.Text += compras[cbCompra.SelectedIndex].Qtt.ToString() + Environment.NewLine;
                tbPreco.Text += compras[cbCompra.SelectedIndex].Preco.ToString() + Environment.NewLine;
                parcela = compras[cbCompra.SelectedIndex].Preco;
                valor += parcela;
                udTotalCompra.Value = valor;
            }
            contador1++;
        }

        //rebate pontos por prémios
        private void cbRebate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contador2 != 0 && meuCartao.Pontos >= ptsRebate)
                ptsRebate += premios[cbRebate.SelectedIndex].Rebate;
            contador2++;
        }

        //transfere pontos doutros cartões
        private void tbTransf_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbTransf.Text, out ptsCard);
        }

        //muda a taxa de bonificação
        private void udTxPrize_ValueChanged(object sender, EventArgs e)
        {
            taxnew = udTxPrize.Value;
        }

        //introduz nome e apelido
        private void tbPrimeiroNome_TextChanged(object sender, EventArgs e)
        {
            namenew = tbPrimeiroNome.Text;
        }
        private void tbApelido_TextChanged(object sender, EventArgs e)
        {
            apelnew = tbApelido.Text;
        }

        //o lojista confirma as acções efetuadas
        //efectiva todas as operações, inscreve-as no cartão e reseta as variáveis de cálculo, os controlos de form e os botões de início
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //verifica q houve compra
            if (tbArtigo.Text != "")
            {
                //atualiza o cartão do cliente
                meuCartao.Compra(valor);
                //reinicializa as compras
                parcela = 0;
                valor = 0;
            }

            meuCartao.levPremio(ptsRebate);
            ptsRebate = 0;

            meuCartao.transfPontos(ptsCard);
            ptsCard = 0;

            meuCartao.mudaTxPrize(taxnew);
            taxnew = 0;

            if (namenew != "" && apelnew != "")
            {
                meuCartao.mudarNome(namenew, apelnew);
                for (int j = 0; j < cartoes.Length; j++)
                    if (cartoes[j].IdCartao == id)
                        cartoes[j].NomeCompleto = namenew+" "+apelnew;
            }
            namenew = "";
            apelnew = "";

            LimpaVisor();

            btnEscritorio.Enabled = true;
            btnLoja.Enabled = true;
            //tbIDcartao.Enabled = false;
        }

        private void LimpaVisor()
        {
            tbIDcartao.Text = string.Empty;
            lblNome.Text = "";
            tbNrCompra.Text = "";
            tbPontos.Text = "";
            tbArtigo.Text = "";
            tbQtt.Text = "";
            tbPreco.Text = "";
            udTotalCompra.Value = 0;
            tbValTotal.Text = "";
            tbTransf.Text = "";
            udTxPrize.Value = 0;
            tbPrimeiroNome.Text = "";
            tbApelido.Text = "";
        }
    }
}
