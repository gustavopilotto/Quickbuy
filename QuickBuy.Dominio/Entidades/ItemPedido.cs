namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Id.ToString()))
                AdicionarCritica("Obrigatório preenchimento da Sequência do Item");
            if (string.IsNullOrEmpty(ProdutoId.ToString()))
                AdicionarCritica("Obrigatório preenchimento do Produto");
            if (string.IsNullOrEmpty(Quantidade.ToString()))
                AdicionarCritica("Obrigatório preenchimento da Quantidade");
        }
    }
}
