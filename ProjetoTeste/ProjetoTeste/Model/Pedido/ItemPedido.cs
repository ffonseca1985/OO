namespace ProjetoTeste.Model.Pedido
{
    public class ItemPedido
    {
        public ItemPedido(string codProduto, decimal quantidade, decimal preco)
        {
            CodProduto = codProduto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public string CodProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }

        public decimal Total
        {
            get
            {
                return Quantidade * Preco;
            }
        }
    }
}


