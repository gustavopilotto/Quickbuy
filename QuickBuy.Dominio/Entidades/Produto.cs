namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Id.ToString()))
                AdicionarCritica("É Obrigatório prencher o Código do Produto");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("É Obrigatório prencher o Nome do Produto");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("É Obrigatório prencher a Descrição do Produto");
            if (string.IsNullOrEmpty(Preco.ToString()))
                AdicionarCritica("É Obrigatório prencher o Preço do Produto");

        }
    }
}
