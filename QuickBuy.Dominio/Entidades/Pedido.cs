using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set;}
        public string NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Um Pedido pode ter um ou muitos Itens de Pedido
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Id.ToString()))
                AdicionarCritica("Obrigatório preenchimento do Número do Pedido");
            if (string.IsNullOrEmpty(DataPedido.ToString()))
                AdicionarCritica("Obrigatório preenchimento da Data do Pedido");
            if (string.IsNullOrEmpty(UsuarioId.ToString()))
                AdicionarCritica("Obrigatório preenchimento do Usuário");
            if (string.IsNullOrEmpty(DataPrevisaoEntrega.ToString()))
                AdicionarCritica("Obrigatório preenchimento da Previsão de Entrega");
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não possui Itens!");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Obrigatório preenchimento do CEP");
            if (string.IsNullOrEmpty(Estado))
                AdicionarCritica("Obrigatório preenchimento do Estado");
            if (string.IsNullOrEmpty(Cidade))
                AdicionarCritica("Obrigatório preenchimento do Cidade");
            if (string.IsNullOrEmpty(EnderecoCompleto))
                AdicionarCritica("Obrigatório preenchimento do Endereço");
            if (string.IsNullOrEmpty(NumeroEndereco))
                AdicionarCritica("Obrigatório preenchimento do Número Endereço");
            if (string.IsNullOrEmpty(FormaPagamentoId.ToString()))
                AdicionarCritica("Obrigatório preenchimento da Forma de Pagamento");
            if (string.IsNullOrEmpty(FormaPagamento.ToString()))
                AdicionarCritica("Obrigatório preenchimento do CEP");
        }
    }
}
